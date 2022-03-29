﻿using System.Collections.Generic;
using Containership.Enums;

namespace Containership.Classes
{
    public class Stack
    {
        private List<Container> _containers = new();
        private int _maxCarryWeight = 120000;
        private bool _available = true;


        public Stack()
        {
            
        }

        public Stack(List<Container> containers, int maxCarryWeight, bool available)
        {
            _containers = containers;
            _maxCarryWeight = maxCarryWeight;
            _available = available;
        }
        
        public int Weight { get; private set; }
        
        
        
        public void Add(Container container)
        {
            _containers.Add(container);
            var bottomContainer = _containers[_containers.Count - 1];
            var totalWeight = 0;
            foreach (var checkContainer in _containers)
            {
                totalWeight += checkContainer.Weight;
                if (checkContainer.Type != ContainerType.Valuable && checkContainer.Type != ContainerType.ValuableCooled && 
                    checkContainer.Weight > bottomContainer.Weight)
                {
                    bottomContainer = checkContainer;
                }
            }
            Weight = totalWeight - bottomContainer.Weight;
            
            //swap containers so the bottom 1 is the heaviest
            if (_containers.IndexOf(bottomContainer)!=_containers.Count-1)
            {
                _containers[_containers.IndexOf(bottomContainer)] = _containers[_containers.Count-1];
                _containers[_containers.Count-1] = bottomContainer;
            }
        }

        public void SetUnavailable()
        {
            _available = false;
        }

        public bool IsAvailable()
        {
            return _available;
        }

        public bool CanCarry(int weight)
        {
            if (!_available)
            {
                return false;
            }
            if (_containers.Count == 0)
            {
                return true;
            }
            // check max weight and if top container is valuable
            if (weight + Weight > _maxCarryWeight)
            {
                return false;
            }
            return true;
        }

        public void ReArrange()
        {
            if (_containers.Count != 0)
            {
                var placeholder = _containers[_containers.Count - 1];
                _containers[_containers.Count - 1] = _containers[0];
                _containers[0] = placeholder;
            }
        }
        
        
        
        public IReadOnlyList<Container> GetContainers()
        {
            return _containers;
        }
    }
}