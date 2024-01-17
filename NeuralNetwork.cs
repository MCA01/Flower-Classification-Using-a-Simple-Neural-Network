using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNeuralNetworkProject
{
    internal class NeuralNetwork
    {
        Neuron neuron1;
        Neuron neuron2;
        Neuron neuron3;
        double learningRate;

        public NeuralNetwork(double learningRate)
        {
            neuron1 = new Neuron();
            neuron2 = new Neuron();
            neuron3 = new Neuron();
            this.learningRate = learningRate;
        }

        // Training the neural network
        public void train(string[] lines, int epochs)
        {
            for (int i = 0; i < epochs; i++)
            {
                for (int j = 0; j < 150; j++)
                {
                    // Getting inputs from lines
                    string[] inputs = lines[j].Split(',');
                    double sepalLength = Convert.ToDouble(inputs[0]);
                    double sepalWidth = Convert.ToDouble(inputs[1]);
                    double petalLength = Convert.ToDouble(inputs[2]);
                    double petalWidth = Convert.ToDouble(inputs[3]);
                    string plantType = inputs[4];

                    // Dividing all input data by 10 and scale it to [0, 1] before training
                    sepalLength /= 10;
                    sepalWidth /= 10;
                    petalLength /= 10;
                    petalWidth /= 10;

                    // Setting inputs
                    neuron1.setInputs(sepalLength, sepalWidth, petalLength, petalWidth, plantType);
                    neuron2.setInputs(sepalLength, sepalWidth, petalLength, petalWidth, plantType);
                    neuron3.setInputs(sepalLength, sepalWidth, petalLength, petalWidth, plantType);

                    // Calculating outputs
                    double output1 = neuron1.calculateOutput();
                    double output2 = neuron2.calculateOutput();
                    double output3 = neuron3.calculateOutput();

                    // Calculating errors for Iris-setosa
                    if (string.Equals(neuron1.PlantType, "Iris-setosa") == true)
                    {
                        if (output1 > output2 && output1 > output3)
                        {
                            if (output1.CompareTo(1) == 1)
                            {
                                neuron1.decreaseWeights(learningRate);
                            }
                            else if (output1.CompareTo(1) == -1)
                            {
                                neuron1.increaseWeights(learningRate);
                            }
                        }

                        else if (output2 > output1 && output2 > output3)
                        {
                            if (output2.CompareTo(0) == 1)
                            {
                                neuron2.decreaseWeights(learningRate);
                            }
                            else if (output2.CompareTo(0) == -1)
                            {
                                neuron2.increaseWeights(learningRate);
                            }
                        }

                        else if (output3 > output1 && output3 > output2)
                        {
                            if (output3.CompareTo(0) == 1)
                            {
                                neuron3.decreaseWeights(learningRate);
                            }
                            else if (output3.CompareTo(0) == -1)
                            {
                                neuron3.increaseWeights(learningRate);
                            }
                        }
                    }

                    else if (string.Equals(plantType, "Iris-versicolor") == true)
                    {
                        if (output1 > output2 && output1 > output3)
                        {
                            if (output1.CompareTo(0) == 1)
                            {
                                neuron1.decreaseWeights(learningRate);
                            }
                            else if (output1.CompareTo(0) == -1)
                            {
                                neuron1.increaseWeights(learningRate);
                            }
                        }

                        else if (output2 > output1 && output2 > output3)
                        {
                            if (output2.CompareTo(1) == 1)
                            {
                                neuron2.decreaseWeights(learningRate);
                            }
                            else if (output2.CompareTo(1) == -1)
                            {
                                neuron2.increaseWeights(learningRate);
                            }
                        }

                        else if (output3 > output1 && output3 > output2)
                        {
                            if (output3.CompareTo(0) == 1)
                            {
                                neuron3.decreaseWeights(learningRate);
                            }
                            else if (output3.CompareTo(0) == -1)
                            {
                                neuron3.increaseWeights(learningRate);
                            }
                        }
                    }

                    else if (string.Equals(plantType, "Iris-virginica") == true)
                    {
                        if (output1 > output2 && output1 > output3)
                        {
                            if (output1.CompareTo(0) == 1)
                            {
                                neuron1.decreaseWeights(learningRate);
                            }
                            else if (output1.CompareTo(0) == -1)
                            {
                                neuron1.increaseWeights(learningRate);
                            }
                        }

                        else if (output2 > output1 && output2 > output3)
                        {
                            if (output2.CompareTo(0) == 1)
                            {
                                neuron2.decreaseWeights(learningRate);
                            }
                            else if (output2.CompareTo(0) == -1)
                            {
                                neuron2.increaseWeights(learningRate);
                            }
                        }

                        else if (output3 > output1 && output3 > output2)
                        {
                            if (output3.CompareTo(1) == 1)
                            {
                                neuron3.decreaseWeights(learningRate);
                            }
                            else if (output3.CompareTo(1) == -1)
                            {
                                neuron3.increaseWeights(learningRate);
                            }
                        }
                    }
                }
            }
        }

        // Testing the neural network
        public int test(string[] lines)
        {
            // Correct results
            int correctResults = 0;
            
            for (int i = 0; i < 150; i++)
            {
                // Getting inputs from lines
                string[] inputs = lines[i].Split(',');
                double sepalLength = Convert.ToDouble(inputs[0]);
                double sepalWidth = Convert.ToDouble(inputs[1]);
                double petalLength = Convert.ToDouble(inputs[2]);
                double petalWidth = Convert.ToDouble(inputs[3]);
                string plantType = inputs[4];

                // Dividing all input data by 10 and scale it to [0, 1] before testing
                sepalLength /= 10;
                sepalWidth /= 10;
                petalLength /= 10;
                petalWidth /= 10;

                // Setting inputs
                neuron1.setInputs(sepalLength, sepalWidth, petalLength, petalWidth, plantType);
                neuron2.setInputs(sepalLength, sepalWidth, petalLength, petalWidth, plantType);
                neuron3.setInputs(sepalLength, sepalWidth, petalLength, petalWidth, plantType);

                // Calculating outputs
                double output1 = neuron1.calculateOutput();
                double output2 = neuron2.calculateOutput();
                double output3 = neuron3.calculateOutput();

                if (string.Equals(neuron1.PlantType, "Iris-setosa") == true)
                {
                    if (output1 > output2 && output1 > output3)
                    {
                        correctResults++;
                        Console.WriteLine("Correct result");
                    }
                    else
                    {
                        Console.WriteLine("Wrong result");
                    }
                }
                else if (string.Equals(neuron1.PlantType, "Iris-versicolor") == true)
                {
                    if (output2 > output1 && output2 > output3)
                    {
                        correctResults++;
                        Console.WriteLine("Correct result");
                    }
                    else
                    {
                        Console.WriteLine("Wrong result");
                    }
                }

                else if (string.Equals(neuron1.PlantType, "Iris-virginica") == true)
                {
                    if (output3 > output1 && output3 > output2)
                    {
                        correctResults++;
                        Console.WriteLine("Correct result");
                    }
                    else
                    {
                        Console.WriteLine("Wrong result");
                    }
                }
            }

            return correctResults;
        }

    }
}    