using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyNeuralNetworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Getting data from iris.data file
            string file = File.ReadAllText("iris.data");
            string[] lines = file.Split('\n');

            // Creating neuralNetwork1 with learningRate = 0.01
            double learningRateNN1 = 0.01;
            NeuralNetwork neuralNetwork1 = new NeuralNetwork(learningRateNN1);

            // Training neuralNetwork1 with 50 epochs
            neuralNetwork1.train(lines, 50);

            // neuralNetwork1 results
            int correctResults = neuralNetwork1.test(lines);
            double accuracy = (correctResults / 150) * 100;
            Console.WriteLine("Accuracy results of the 50 epochs and 0.01 learning rate training: " + accuracy + "%");
            Console.ReadKey();
        }
    }
}
