using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNeuralNetworkProject
{
    internal class Neuron
    {
        // Inputs
        private double sepalLength;
        private double sepalWidth;
        private double petalLength;
        private double petalWidth;
        private string plantType;

        
        // Weigths
        double sepalLengthWeight;
        double sepalWidthWeight;
        double petalLengthWeight;
        double petalWidthWeight;

        // Assigning random weights in [0, 1] range
        Random random;
        public Neuron()
        {
            random= new Random();
            sepalLengthWeight = random.NextDouble();
            sepalWidthWeight = random.NextDouble();
            petalLengthWeight = random.NextDouble();
            petalWidthWeight = random.NextDouble();
        }

        // Setting inputs
        public void setInputs(double sepalLength, double sepalWidth, double petalLength, double petalWidth, string plantType)
        {
            this.sepalLength = sepalLength;
            this.sepalWidth = sepalWidth;
            this.petalLength = petalLength;
            this.petalWidth = petalWidth;
            this.plantType = plantType;
        }

        // Getter for plantType
        public string PlantType
        {
            get
            {
                return plantType;
            }
        }

        // Output
        public double calculateOutput()
        {
            return sepalLength * sepalLengthWeight + sepalWidth * sepalWidthWeight + petalLength * petalLengthWeight + petalWidth * petalWidthWeight;
        }

        public void decreaseWeights(double learningRate)
        {
            sepalLengthWeight -= learningRate * sepalLength;
            sepalWidthWeight -= learningRate * sepalWidth;
            petalLengthWeight -= learningRate * petalLength;
            petalWidthWeight -= learningRate * petalWidth;
        }
        
        public void increaseWeights(double learningRate)
        {
            sepalLengthWeight += learningRate * sepalLength;
            sepalWidthWeight += learningRate * sepalWidth;
            petalLengthWeight += learningRate * petalLength;
            petalWidthWeight += learningRate * petalWidth;
        }
    }
}
