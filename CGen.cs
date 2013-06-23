using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RobotProgrammer
{
    class CGen
    {
        public string Main;
        public string Commands;

        private ArrayList Errors;

        /// <summary>
        /// Generate the Main.c and the Commands.c for the robot code passed into the application
        /// </summary>
        /// <param name="RobotCode">Robot Code</param>
        /// <returns>List of Errors</returns>
        public ArrayList GenerateCFromRobot(string RobotCode)
        {
            // create a new arraylist for any errors to be inserted into
            Errors = new ArrayList();

            // Generate the C Code
            GenerateMain();
            GenerateCommands();


            return Errors;
        }

        private void GenerateMain()
        {

        }

        private void GenerateCommands()
        {

        }

    }
}
