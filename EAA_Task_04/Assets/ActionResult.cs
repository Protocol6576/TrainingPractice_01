using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAA_Task_04.Assets
{
    class ActionResult
    {
        private string action;
        private string result;
        private double intResult;

        public ActionResult(string Action, string Result, double IntResult)
        {
            action = Action;
            result = Result;
            intResult = IntResult;
        }

        public void ShowResult(int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write("                          ");
            Console.SetCursorPosition(posX, posY);
            Console.Write(action);

            Console.SetCursorPosition(posX, posY + 1);
            Console.Write("                          ");
            Console.SetCursorPosition(posX, posY + 1);
            Console.Write(result + ": " + intResult);
        }
    }
}
