let maxCarryWeight = 120000
let maxConatainerWeight = 30000
let minContainerWeight = 4000
let distributionMargin = 0.2
let minShipLoad = 0.5

let ship = {
    containerWidths: 5,
    containerLengths: 20,
    maxLoad: 2000000
}

let testcontainer = {
    random:true
}

let layout = [];

let containerlist = [];

function generateLayout(ship){
    for (let i = 0; i < ship.containerLengths; i++){
        let obj = `[`
        for (let j = 0; j < ship.containerWidths -1; j++){
            obj += "{\"isTaken\":false},"
        }
        obj += "{\"isTaken\":false}]"
        let returnObj = JSON.parse(obj)
        layout.push(returnObj)
    }
}

function generateContainers(amount, container){
    if(container.random) {
        for (let i = 0; i < amount; i++) {
            let container = {};
            container.isValueable = false;
            container.needsCooling = false;
            container.weight = minContainerWeight + Math.floor(Math.random() * (maxConatainerWeight - minContainerWeight));
            if (Math.floor(Math.random() * 1000) < 25) {
                container.isValueable = true;
            }
            if (Math.floor(Math.random() * 1000) < 25) {
                container.needsCooling = true;
            }
            containerlist.push(container);
        }
    }else{
        for (let i = 0; i < amount; i++) {
            
        }
    }
    console.log();
}

function sortContainers(ship, containers){
    let valuableContainers = [];
    let cooledContainers = [];
    let standardContainers = [];
    let valuableCooledContainers = [];
    containers.forEach((container)=>{
        if (container.isValueable && container.needsCooling){
            valuableCooledContainers.push(container);
        } else if (container.isValueable){
            valuableContainers.push(container)
        } else if (container.needsCooling){
            cooledContainers.push(container)
        } else {
            standardContainers.push(container)
        }
    })
    return {
        standardContainers,
        valuableContainers,
        cooledContainers,
        valuableCooledContainers
    };
}

function start(){
    let cont = true;
    generateLayout(ship)
    generateContainers(100, testcontainer)
    let totalWeight = 0;
    containerlist.forEach((container)=>{
        totalWeight += container.weight;
    })
    if (totalWeight < (ship.maxLoad * minShipLoad) || totalWeight > ship.maxLoad){
        console.log("wrong weight: " + totalWeight)
    }
    let sortedContainers = sortContainers(ship, containerlist)
    sortedContainers.cooledContainers.forEach((container)=>{
        for (const spot of layout[0]) {
            if (spot.isTaken === false){
                spot.container = container;
                spot.isTaken = true;
                break;
            }
            if (layout[0].length === layout[0].indexOf(spot) + 1){
                console.log("Too many cooled containers")
                cont = false;
            }
        }
    })
    if(cont) {
        sortedContainers.valuableCooledContainers.forEach((container) => {
            for (const spot of layout[0]) {
                if (!spot.isTaken) {
                    spot.container = container;
                    spot.isTaken = true;
                    break;
                }
                if (layout[0].length === layout[0].indexOf(spot) + 1) {
                    console.log("Too many cooled containers")
                    cont = false;
                }
            }
        })
    }
    if(cont) {
        let index = 0;
        sortedContainers.valuableContainers.forEach((container) => {
            let placed = false;
            for (index; ; index++) {
                let stop = false;
                if (index === 0 || index === layout.length - 1) {
                    for (const spot of layout[index]) {
                        if (!spot.isTaken) {
                            spot.container = container;
                            spot.isTaken = true;
                            stop = true;
                            placed = true;
                            break;
                        }
                    }
                    if (stop) {
                        break;
                    }
                }
            }
            if(!placed){
                console.log("Too many valuable containers")
                cont = false;
            }
        })
    }
    if (cont) {
        index = 0;
        sortedContainers.standardContainers.forEach((container) => {
            let placed = false;
            for (index; index<ship.containerLengths ; index++) {
                let stop = false;
                for (const spot of layout[index]) {
                    if (!spot.isTaken) {
                        spot.container = container;
                        spot.isTaken = true;
                        stop = true;
                        placed = true;
                        break;
                    }
                }
                if (stop) {
                    break;
                }
            }
            if (!placed){
                console.log("Too many containers")
            }
        })
    }
    layout.forEach((row)=>{
        console.log(JSON.stringify(row))
    })
}

start();