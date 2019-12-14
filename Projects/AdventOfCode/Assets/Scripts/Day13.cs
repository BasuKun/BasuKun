using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace intcode
{
    public class Day13 : Day9
    {
        public GameObject wall;
        public GameObject block;
        public GameObject paddle;
        public GameObject ball;
        public long score = 0;

        GameObject ballInstance;
        GameObject paddleInstance;

        public int blockAmount;

        void Start()
        {
            StartCoroutine("RunProgram");
        }

        void Update()
        {
            if (output.Count == 3)
            {
                if (output[0] == -1 && output[1] == 0)
                {
                    score = output[2];
                    blockAmount--;

                    if (blockAmount == 0)
                    {
                        Debug.Log(score);
                    }
                }
                else
                {
                    switch (output[2])
                    {
                        case 0: //nothing
                            break;
                        case 1: //wall
                            Instantiate(wall, new Vector2(output[0], -output[1]), transform.rotation);
                            break;
                        case 2: //block
                            Instantiate(block, new Vector2(output[0], -output[1]), transform.rotation);
                            blockAmount++;
                            break;
                        case 3: //paddle
                            if (paddleInstance == null)
                            {
                                paddleInstance = Instantiate(paddle, new Vector2(output[0], -output[1]), transform.rotation);
                            }
                            else
                            {
                                paddleInstance.transform.position = new Vector2(output[0], -output[1]);
                            }
                            break;
                        case 4: //ball
                            if (ballInstance == null)
                            {
                                ballInstance = Instantiate(ball, new Vector2(output[0], -output[1]), transform.rotation);
                            }
                            else
                            {
                                ballInstance.transform.position = new Vector2(output[0], -output[1]);
                            }
                            break;
                    }
                }

                output.RemoveRange(0, 3);
            }

            if (paddleInstance != null && ballInstance != null)
            {
                PaddleAI();
            }
        }

        public void PaddleAI()
        {
            if (ballInstance.transform.position.x < paddleInstance.transform.position.x)
            {
                inputInstruction = -1;
            }
            else if (ballInstance.transform.position.x == paddleInstance.transform.position.x)
            {
                inputInstruction = 0;
            }
            else if (ballInstance.transform.position.x > paddleInstance.transform.position.x)
            {
                inputInstruction = 1;
            }
        }
    }
}
