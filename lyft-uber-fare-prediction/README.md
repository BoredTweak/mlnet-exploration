# Lyft/Uber Fare Prediction

Predict fare prices per input parameters of distance, cab type, and timestamp
- https://en.wikipedia.org/wiki/Regression_analysis

## Run the example model

From the [SampleRegression](SampleRegression/) directory, run `dotnet run 4 lyft 1543284023677` to predict the price for a 4 mile trip via lyft on Tue Nov 27 2018 02:00:23 UTC.

From the [SampleRegression](SampleRegression/) directory, run `dotnet run 500 lyft 1543284023677` to predict the price for a 500 mile trip via lyft on Tue Nov 27 2018 02:00:23 UTC.

Notes for creating inputs and describing weird outputs: 
- The maximum distance included in the dataset is 7.86 
- The maximum price included in the dataset is 97.5
- The data is from 2018 and all timestamps are relevant to 2018

## Data 

Data is sourced from [this resource](https://www.kaggle.com/datasets/ravi72munde/uber-lyft-cab-prices) then trimmed down for this demonstration.

**About this file per the `About Dataset` section of the above link:**

With no public data of rides/prices shared by any entity, we tried to collect real-time data using Uber&Lyft api queries and corresponding weather conditions. We chose a few hot locations in Boston from [this map](https://www.google.com/maps/d/u/0/viewer?mid=1CoeBbhbf59z8EopJGvMJxEe1NNo&ll=42.45357621635435%2C-71.21848534999998&z=10). We built a custom application in Scala to query data at regular intervals and saved it to DynamoDB. The project can be found [here](https://github.com/ravi72munde/scala-spark-cab-rides-predictions) on GitHub. We queried cab ride estimates every 5 mins and weather data every 1 hr.

The data is approx. for a week of Nov '18 ( I actually have included data collected while I was testing the 'querying' application so might have data spread out over more than a week. I didn't consider this as a time-series problem so did not worry about regular interval. The chosen interval was to query as much as data possible without unnecessary redundancy. So data can go from end week of Nov to few in Dec)

The Cab ride data covers various types of cabs for Uber & Lyft and their price for the given location. You can also find if there was any surge in the price during that time. Weather data contains weather attributes like temperature, rain, cloud, etc for all the locations taken into consideration.


## Model Generation

To generate this model open a terminal instance to this directory and run `mlnet regression --dataset .\cab_rides.csv --label-col price`

