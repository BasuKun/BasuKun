using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day8
    {
        public static List<string> RawList = new List<string>();
        public static List<Instruction> Instructions = new List<Instruction>();
        public static int accumulator = 0;
        public static bool programTerminated = false;

        public static void Execute()
        {
            RawList = FileParser.ParseFileString(8);
            Instructions = PopulateInstructionsList();
            int answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static int PartOne()
        {
            return Program();
        }

        public static int PartTwo()
        {
            foreach (var inst in Instructions)
            {
                accumulator = 0;

                switch (inst.op)
                {
                    case "acc":
                        continue;
                    case "jmp":
                        inst.op = "nop";
                        break;
                    case "nop":
                        inst.op = "jmp";
                        break;
                }
                int answer = Program();

                if (programTerminated) return answer;

                foreach (var i in Instructions) i.wasExecuted = false;
                inst.op = inst.op == "jmp" ? "nop" : "jmp";
            }
            return 0;
        }

        public static int Program()
        {
            int next = 1;
            for (int i = 0; i < Instructions.Count; i += next)
            {
                next = 1;
                Instruction cur = Instructions[i];
                if (cur.wasExecuted) return accumulator;

                switch (cur.op)
                {
                    case "acc":
                        accumulator += cur.arg;
                        break;
                    case "jmp":
                        next = cur.arg;
                        break;
                    case "nop":
                        break;
                }
                cur.wasExecuted = true;
            }
            programTerminated = true;
            return accumulator;
        }

        public static List<Instruction> PopulateInstructionsList()
        {
            List<Instruction> list = new List<Instruction>();
            foreach (var str in RawList)
            {
                var splitStr = str.Split(' ');
                list.Add(new Instruction(splitStr[0], int.Parse(splitStr[1])));
            }
            return list;
        }
    }

    public class Instruction
    {
        public string op { get; set; }
        public int arg { get; set; }
        public bool wasExecuted { get; set; }

        public Instruction(string op, int arg)
        {
            this.op = op;
            this.arg = arg;
        }
    }
}

