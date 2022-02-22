using System;

namespace ClassLibrary
{
    public class Car
    {
        private int _id;
        private string _model;
        private double _price;
        private string _licensePlate;

        public int Id
        {
            get => _id;
            set
            {
                if (value==0)
                {
                    throw new ArgumentOutOfRangeException("id kan ikke være 0");
                }
                _id = value;
            }
        }

        public string Model
        {
            get => _model;
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("Model name is too short");
                }
                _model = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("Giv en ordenlig pris");
                }
                _price = value;
            }
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("værdien kan ikke være null");
                }
                if (value.Length<2||value.Length>7)
                {
                    throw new ArgumentOutOfRangeException("nummerpladen er for lang eller for kort");
                }
                _licensePlate = value;
            }
        }

        public Car(int id, string model, double price, string licensePlate)
        {
            Id = id;
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
        }





    }
}
