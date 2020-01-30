using System;
using System.Collections.Generic;
using System.Text;

namespace Sphere_project1
{
	/**
  * This class models a sphere object
  * @author Gage Cumella
  * @version 1.0
  * Lab02-Solution
  * SP19
  */
	public class Sphere_project1
	{

		private double diameter;

		/**
		 * Empty-argument constructor to put object
		 * into a consistent state.
		 */
		public Sphere_project1()
		{
			diameter = 2.0;
		}//end constructor

		/**
		 * Constructor accepts value of diameter.
		 * Preferred constructor.
		 * @param diameter
		 */
		public Sphere_project1(double diameter)
		{

			this.setDiameter(diameter);

		}//end constructor

		/**
		 * Calculates the volume of the sphere.
		 * @return volume
		 */
		public double getVolume()
		{

			return (4.0 / 3.0) * Math.PI * Math.Pow(diameter / 2, 3);

		}//end getVolume

		/**
		 * Calculates the surface area of the sphere.
		 * @return - surface area
		 */
		public double getSurfaceArea()
		{

			return 4.0 * Math.PI * Math.Pow(diameter / 2, 2);
		}//end getSurfaceArea


		/**
		 * Getter for diameter
		 * @return
		 */
		public double getDiameter()
		{
			return diameter;
		}//end getDiameter

		/**
		 * Setter for diameter. Checks bound on
		 * formal parameter and resets to 2 if
		 * the value is less than 2.
		 * @param diameter
		 */
		public void setDiameter(double diameter)
		{
			if (diameter < 2)
				this.diameter = 2;
			else
				this.diameter = diameter;
		}//end setDiameter

		public string GetToString()
		{
			return "Sphere [diameter=" + diameter + "]";
		}
	}//end class
  
    }