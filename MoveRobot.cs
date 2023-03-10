using System;
namespace Task
{
    public class MoveRobot
    {
        protected int xBorder;
        protected int yBorder;
        protected int xPos;
        protected int yPos;
        protected static Dictionary<string, string> directionsMap = new Dictionary<string, string>(){
            {"nr","east"},
            {"nl","west"},
            {"nf","north"},
            {"sr","east"},
            {"sl","west"},
            {"sf","south"},
            {"wf","west"},
            {"ef","east"},
            {"wr","north"},
            {"wl","south"},
            {"er","south"},
            {"el","north"}
        };

        public MoveRobot(int xBorder,int yBorder){
            xPos = 1;
            yPos = 1;
            this.xBorder = xBorder;
            this.yBorder = yBorder;
        }

        public string move(string directions){
            dynamic currentDirectionData = new { xPos = 1, yPos = 1, curDirection = "north" };
            foreach (char dir in directions)
            {
                
                string next_direction = predictNextMove(currentDirectionData.curDirection,dir);
                currentDirectionData = validateNextDirections(currentDirectionData.curDirection,next_direction);

            }
            return currentDirectionData.xPos + "," +
                    currentDirectionData.yPos+ "," + currentDirectionData.curDirection;
                    
        }

        private string predictNextMove(string currentDirection, char direction) {
            
            return directionsMap[currentDirection[0] + "" + Char.ToLower(direction)];

        }

        private dynamic validateNextDirections(string cur_direction,string next_direction){
            if (next_direction == "east") {

                if (this.xPos + 1 > 0 && this.xPos + 1 < this.xBorder) {
                    cur_direction = next_direction;
                    this.xPos++;
                }
            }
            else if (next_direction == "west") {

                if (this.xPos - 1 > 0 && this.xPos - 1 < this.xBorder) {
                    cur_direction = next_direction;
                    this.xPos--;
                }
            }

            else if (next_direction == "south") {

                if (this.yPos - 1 > 0 && this.yPos - 1 < this.yBorder) {
                    cur_direction = next_direction;
                    this.yPos--;
                }
            }

            else if (next_direction == "north") {

                if (this.yPos + 1 > 0 && this.yPos + 1 < this.yBorder) {
                    cur_direction = next_direction;
                    this.yPos++;
                }
            }

           
            return new { xPos = this.xPos, yPos = this.yPos, curDirection = cur_direction };
        }
    }
}