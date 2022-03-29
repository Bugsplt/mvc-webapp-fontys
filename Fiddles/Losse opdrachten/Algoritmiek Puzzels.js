//returns sum of all numbers between min and max dividable by valueLists numbers
function puzzleAnswers1(valueList, max, min){
    let returnVal = 0;
    for(let i=min; i<max; i++){
        let nr = 0;
        valueList.forEach((value)=>{
            if (i % value === 0 && i !== 0){
                nr = i;
            }
        })
        returnVal += nr;
    }
    return returnVal;
}

console.log(puzzleAnswers1([3,5],1000,0))

//returns the sum of all fibonnaci numbers under given max
function puzzleAnswers2(max){
   let lastNumber = 1;
   let newNumber = 1;
   let placeHolder = 0;
   let fibonnaciSum = 0;
   for (;newNumber<max;){
       if (newNumber%2===0) {
           fibonnaciSum += newNumber;
       }
       placeHolder = newNumber;
       newNumber += lastNumber;
       lastNumber = placeHolder;
   }
   return fibonnaciSum;
}

console.log(puzzleAnswers2(4000000))

//returns the biggest prime factor of given nr
function puzzleAnswers3(nr){
    let highestDivider;
    for (let i = 1; i <= nr/2 ; i ++){
        if(nr % i === 0){
            highestDivider = nr / i;
            if (isPrime(highestDivider)){
                return (highestDivider);
            }
        }
    }
    return "not dividable by primes"
}

console.log(puzzleAnswers3(600851475143))

//returns the biggest palindrome number that can be made by multiplying integers with the given length
function puzzleAnswers4(nrLength){
    let maxNr = "1";
    let palindromeList = [0];
    for (let i = 0; i<nrLength;i++){
        maxNr += 0;
    }
    for (let i = parseInt(maxNr);i>0;i--){
        for(let j = parseInt(maxNr);j>0;j--){
            if (isPalindrome(i*j)){
               palindromeList.push(parseInt(i*j));
            }
        }
    }
    let biggestPalindrome = 0;
    palindromeList.forEach((palindrome)=>{
        if(palindrome>biggestPalindrome){
            biggestPalindrome=palindrome;
        }
    })
    return biggestPalindrome;
}

console.log(puzzleAnswers4(3))

//return the smallest number dividable by all numbers 1-20
function puzzleAnswers5(){
    let foundNr = false
    let i;
    for (i = 20;foundNr===false;i+=20){
        foundNr = isDividable(i)
    }
    return i-20;
}

console.log(puzzleAnswers5())

//returns the value of the squareofsumms - the sumofsquares of the given ints from 1-given nr
function puzzleAnswers6(nrOfInts){
    return squareOfSum(nrOfInts) - sumOfSquare(nrOfInts);
}

console.log(puzzleAnswers6(100))

//returns the prime at the given spot in the array of all primes
function puzzleAnswers7(primeNr){
    let j=1;
    let prime = 2;
    for (let i=1;j<primeNr;i+=2){
        if (isPrime(i)){
            prime = i;
            j++
        }
    }
    return prime;
}

console.log(puzzleAnswers7(10001))

//returns the biggest product of the given number of consecutive ints within the defined int
function puzzleAnswers8(amountOfInts){
    let int = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
    let biggestProduct = 0;
    for (let i=0;i<=1000-amountOfInts;i++){
        let product = +int[i];
        for (let j = i + 1;j<amountOfInts+i;j++){
            product = product*int[j];
        }
        if (product>biggestProduct){
            biggestProduct=product;
        }
    }
    return biggestProduct;
}

console.log(puzzleAnswers8(13))

//returns the pythagors set which sums to 1000
function puzzleAnswers9(){
 for (let i = 1; i<=500;i++){
     if (1000*(500-i) % (1000-i) === 0){
         return (i * (1000*(500-i) / (1000-i)) * (1000 - i - (1000*(500-i) / (1000-i))));
     }
 }
}

console.log(puzzleAnswers9())

//returns the sum of all primes under the given number
function puzzleAnswers10(primesUnder){
    let primeSum = 2;
    for (let i = 1; i < primesUnder; i+=2){
        if (isPrime(i)){
            primeSum += i;
        }
    }
    return primeSum;
}

console.log(puzzleAnswers10(2000000))




// used functions

function sumOfSquare(nrOfInts){
    let returnVal = 0;
    for (let i = 1;i<=nrOfInts;i++){
        returnVal += (i*i);
    }
    return returnVal;
}

function squareOfSum(nrOfInts){
    let returnVal = 0;
    for (let i = 1;i<=nrOfInts;i++){
        returnVal += i;
    }
    return returnVal*returnVal;
}

function isDividable(input){
    let nrArr = [11,12,13,14,15,16,17,18,19];
    for (let i=0; i<nrArr.length;i++){
        if (input % nrArr[i] !== 0){
            return false;
        }
    }
    return true;
}

function isPalindrome(nr){
    let nrString = nr.toString();
    let reversedNr = "";
    for (let i = nrString.length -1; i >= 0 ; i--){
        reversedNr += nrString[i];
    }
    if (reversedNr === nrString)
    {
        return true
    }

    return false
}

function isPrime(nr) {
    if (nr === 1) return false;
    if (nr === 2) return true;
    if (nr === 3) return true;
    if (nr % 2 === 0) return false;
    if (nr % 3 === 0) return false;

    let i = 5;
    //optimal version found on stack overflow V
    let w = 2;
    //optimal version found on stack overflow ^
    while (i * i <= nr) {
        if (nr % i === 0) {
            return false;
        }
        //optimal version found on stack overflow V
        i += w;
        w = 6 - w;
        //optimal version found on stack overflow ^
        //my slow version v
        // i += 2;
        //my slow version ^
    }
    return true;
}

function test(){
    let var1 = "1"
    let var2 = "x"
    
    var1 = var1 + var2
    
    console.log(var1)
}
