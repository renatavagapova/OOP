using System;
using System.Collections.Generic;
using System.Text;

namespace lesson4._1
{
    public class Building
    {
        /// <summary>
        /// Уникальный номер здания
        /// </summary>
        uint _idBuilding;

        /// <summary>
        /// Высота
        /// </summary>
        float _height;

        /// <summary>
        /// Этажность
        /// </summary>
        short _floor;

        /// <summary>
        /// Количество квартир
        /// </summary>
        uint _flat;

        /// <summary>
        /// Количества подъездов
        /// </summary>
        uint _entrance;

        static uint counter = 1;

        public void Add(float height, short floor, uint flat, uint entrance)
        {
            _idBuilding = CounterPlus(counter);

            _height = height;
            _floor = floor;
            _flat = flat;
            _entrance = entrance;
        }
        public void Add(uint apartmentsOnTheFloor, short floor, uint entrance)
        {
            _idBuilding = counter++;

            _floor = floor;
            _entrance = entrance;

            _flat = apartmentsOnTheFloor * (uint)_floor * _entrance;

            BuildingHeight(_floor);


        }
        public void BuildingHeight(short floor)
        {
            float basement = 2.1F;
            float attic = 4.2F;

            _floor = floor;

            _height = (floor * 3) + basement + attic;
        }

        public void Print()
        {

            Console.WriteLine($"Уникальный номер здания: {_idBuilding}; высота: {_height}; этажность: {_floor}; количество квартир: {_flat}; количества подъездов: {_entrance};");
        }

        public uint CounterPlus(uint counter)
        {
            return counter++;
        }
    }
}
