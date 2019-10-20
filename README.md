# Asteroid Builders
We are Asteroid Builders and our challenge is “Chasers of the Lost Data”, this challenge centers on the problem of the data we miss and tries to recreate it using machine learning, our job is to improve the performance of the machine learning to obtain accurate new data.
The branch we focused on is Meteorite Landings, there’s a lot of meteorite landings we miss because is difficult to access to them, some other times they disintegrate or are way too small to find them. A lot of meteorites are found in Antarctica because is easier to find them in there, but as a result, data tends to only that region.

## Smote
Our solution is SMOTE (Synthetic Minority Over-sampling TEchnique), created by Nitesh V. Chawla, 	Kevin W. Bowyer, Lawrence O. Hall and W. Philip Kegelmeyer; this technique for machine learning creates new data based on small, undistributed examples and replicates a more balanced new data so in that way researchers can get a way to investigate more of the rare phenomena.
Our project divides in two, a SMOTE Analysis and an Asteroid Simulator.

## Smote Analysis
SMOTE Analysis section contains the algorithm we utilized for the machine learning in Python, it uses numpy, pandas and plotly.graph_objects libraries. In there you can find the results of the processed Meteorite Landings data from NASA, this are also represented in pie charts where you can appreciate how uneven and unbalanced is the data. 

![alt text](https://ibb.co/ZznG8yt)

After that it shows the new synthetic data that was created where you observe the new balanced data.
![alt text](https://ibb.co/WzRLjXZ)
You can also compare their locations in the graphs.
![alt text](https://ibb.co/jvsgt7M) 
The way SMOTE works is by finding the nearest neighbor of each data point and then randomly fills the space between until it finally gets a more equally distributed data.

## Asteroid Simulator
The second section contains an Asteroid Simulator where you can observe the NASA’s Meteorite Landings data in the Earth and the results of SMOTE synthetic new data.
The simulator engine is Unity, the simulator is developed by us, it shoots different types of meteorites and lands them in different Earth locations provided by the NASA and SMOTE’s algorithm. 
