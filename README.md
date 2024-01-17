# Flower-Classification-Using-a-Simple-Neural-Network
A simple artificial neural network for detecting flowers.

It was an assignment from the Data Structures lecture.

- An algorithm has been developed to determine which of the three different species of Iris flower (or Lily) a flower observed in nature belongs to. We have data obtained by measuring 150 examples from each species of flower. For each example, 4 features are provided (sepal length, sepal width, petal length, petal width), and the information about which class (species) it belongs to is given. The dataset is available at https://archive.ics.uci.edu/ml/machine-learning-databases/iris/iris.data and is used in the project.

- Artificial Neural Networks (ANN), which are a machine learning method and form the foundation of the deep learning field, are built upon the fundamental structures known as Artificial Neurons. ANNs are utilized in solving various problems, including classification, clustering, and prediction.

- There are 3 neurons, they have 4 inputs and 1 output.
    - Inputs are the same for all 3 of them and they are:
       - Sepal length
       - Sepal width
       - Petal length
       - Petal width
    - Outputs of the neurons gives the result.

  ### Model and Functioning of a Neuron
- The summation function is performed by taking the sum of the products of inputs and weights.

- In Supervised Learning, along with the inputs, the desired output values (target) are provided by the system. The iris.data dataset, which is linked above, is used during the training of the network. In the training set, there are 150 pieces of data (plant samples) in the format 5.1,3.5,1.4,0.2,Iris-setosa. The first four values in each row represent the features of the respective flower sample and are given as input to the network. The last value represents the species of the corresponding iris plant and is used as the output, serving as the target or expected value.

