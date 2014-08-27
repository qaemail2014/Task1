using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class Plane
    {
        public double capacity;
        public double dimensions;
        public double range;

        public void PlaneOOP(double capacity, double dimensions, double range)
        {
            this.capacity = capacity;
            this.dimensions = dimensions;
            this.range = range;
        }


        public double getCapacity()
        {
            return capacity;
        }


        public void setCapacity(double capacity)
        {
            this.capacity = capacity;
        }


        public double getDimensions()
        {
            return dimensions;
        }


        public void setDimensions(double dimensions)
        {
            this.dimensions = dimensions;
        }


        public double getRange()
        {
            return range;
        }


        public void setRange(double range)
        {
            this.range = range;
        }
    }


/*  public class LightPlane : Plane
    {
        public string chassisType;

        public void LightPlaneOOP (string chassisType)
        {
            this.chassisType = chassisType;
        }

    }
    public class CargoPlane : Plane
    {
        public string TypeOfLoading;
        public void CargoPlaneOOP(string TypeOfLoading)
        {
            this.TypeOfLoading = TypeOfLoading;
        }
    }
    public class Airliner : Plane
    {
        public int NumSeats;
        public void Airliner(int NumSeats)
        {
            this.NumSeats = NumSeats;
        }
    }*/

  public class Airport
    {
      private Plane[] plane;

      public Airport()
      {
          plane = new Plane[10];
      }

      public void sortPlane()
      {
          Plane temp = new Plane();
          for (int i = 0; i < plane.Length - 1; i++)
          {
              for (int j = 0; j < plane.Length - 1; j++)
              {
                  if (plane[j].getRange() > plane[j + 1].getRange())
                  {
                      temp = plane[j + 1];
                      plane[j + 1] = plane[j];
                      plane[j] = temp;
                  }
              }
          }
      }


      public double getSumCapacuty()
      {
          double sumCapacuty = 0;
          foreach (Plane sumCapacutyElements in plane)
      {
          sumCapacuty = sumCapacuty + sumCapacutyElements.getCapacity();
      }
          return sumCapacuty;
      }


      public double getSumDimensions()
      {
          double sumDimensions=0;
          foreach (Plane sumDimensionsElements in plane)
      {
          sumDimensions = sumDimensions + sumDimensionsElements.getDimensions();
      }
          return sumDimensions;
      }


      public double getSumRange()
      {
          double sumRange = 0;
          foreach (Plane sumRangeElements in plane)
          {
              sumRange = sumRange + sumRangeElements.getRange();
          }
          return sumRange;
      }


      public void findByCapacity(double lowLimit, double hightLimit)
      { 
          int counter = 0;          
      foreach (Plane element in plane)
      {
      if (element.getCapacity()>=lowLimit && element.getCapacity()<=hightLimit)
      {
          Console.WriteLine("Грузоподъёмность саолёта = {0}, габариты самолёта = {1}, дальность полёта самолёта = {2}", element.getCapacity(), element.getDimensions(), element.getRange());
          counter++;
      }
      }
      if (counter == 0)
      {
          Console.WriteLine("Подходящий самолётов по грузоподъёмности не найдено");
      }
      }


      public void findByDimensions(double lowLimit, double hightLimit)
      {
          int counter = 0;
          foreach (Plane element in plane)
          {
              if (element.getDimensions() >= lowLimit && element.getDimensions() <= hightLimit)
              {
                  Console.WriteLine("Грузоподъёмность саолёта = {0}, габариты самолёта = {1}, дальность полёта самолёта = {2}", element.getCapacity(), element.getDimensions(), element.getRange());
                  counter++;
              }
          }
          if (counter == 0)
          {
              Console.WriteLine("Подходящий самолётов по габаритам не найдено");
          }
      }


      public void findByRange (double lowLimit, double hightLimit)
      {
          int counter = 0;
          foreach (Plane element in plane)
          {
              if (element.getRange() >= lowLimit && element.getRange() <= hightLimit)
              {
                  Console.WriteLine("Грузоподъёмность саолёта = {0}, габариты самолёта = {1}, дальность полёта самолёта = {2}", element.getCapacity(), element.getDimensions(), element.getRange());
                  counter++;
              }
          }
          if (counter == 0)
          {
              Console.WriteLine("Подходящий самолётов по дальности полёта не найдено");
          }
      }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
}

