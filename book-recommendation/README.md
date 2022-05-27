# Book Recommendation

Recommend a ramen brand for a user by input style and country preference. 

  - https://en.wikipedia.org/wiki/Matrix_factorization_(recommender_systems)

## Run the example model

From the [SampleRecommendation](./SampleRecommendation/) directory, run `dotnet run 276725 0446520802` to ask the model to recommend a rating for ISBN 0446520802 for user 276725. 

## Data 

Data is sourced from [this resource](https://www.kaggle.com/datasets/ruchi798/bookcrossing-dataset).

About this file
Stars indicate the ISBN quality on a 10-point scale.

## Model Generation

To generate this model open a terminal instance to this directory and run `mlnet recommendation --dataset .\BX-Book-Ratings.csv --user-col 0 --item-col 1 --rating-col 2`
