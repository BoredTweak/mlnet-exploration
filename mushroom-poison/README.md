# Mushroom Poison Classification

Guess if a mushroom is poisonous by input descriptions

  - https://en.wikipedia.org/wiki/Binary_classification
  - https://en.wikipedia.org/wiki/Multiclass_classification

## Run the example model

From the [SampleClassification](./SampleClassification/) directory, run `dotnet run b c f` to ask the model to predict if a foul smelling mushroom with a cinnamon-colored, bell-shaped cap is likely to be edible or poisonous. 

Next, run `dotnet run b c n` to ask the model to predict if a odorless mushroom with a cinnamon-colored, bell-shaped cap is likely to be edible or poisonous. 

In the model generated for this demo it appears that smell was a highly relevant factor in predicting if a mushroom is poisonous.

## Data 

Data is sourced from [this resource](https://www.kaggle.com/datasets/uciml/mushroom-classification) then trimmed down for this demonstration.

About this file
Attribute Information: (classes: edible=e, poisonous=p)

- cap-shape: bell=b,conical=c,convex=x,flat=f, knobbed=k,sunken=s
- cap-surface: fibrous=f,grooves=g,scaly=y,smooth=s
- cap-color: brown=n,buff=b,cinnamon=c,gray=g,green=r,pink=p,purple=u,red=e,white=w,yellow=y
- bruises: bruises=t,no=f
- odor: almond=a,anise=l,creosote=c,fishy=y,foul=f,musty=m,none=n,pungent=p,spicy=s
- gill-attachment: attached=a,descending=d,free=f,notched=n
- gill-spacing: close=c,crowded=w,distant=d
- gill-size: broad=b,narrow=n
- gill-color: black=k,brown=n,buff=b,chocolate=h,gray=g, green=r,orange=o,pink=p,purple=u,red=e,white=w,yellow=y
- stalk-shape: enlarging=e,tapering=t
- stalk-root: bulbous=b,club=c,cup=u,equal=e,rhizomorphs=z,rooted=r,missing=?
- stalk-surface-above-ring: fibrous=f,scaly=y,silky=k,smooth=s
- stalk-surface-below-ring: fibrous=f,scaly=y,silky=k,smooth=s
- stalk-color-above-ring: brown=n,buff=b,cinnamon=c,gray=g,orange=o,pink=p,red=e,white=w,yellow=y
- stalk-color-below-ring: brown=n,buff=b,cinnamon=c,gray=g,orange=o,pink=p,red=e,white=w,yellow=y
- veil-type: partial=p,universal=u
- veil-color: brown=n,orange=o,white=w,yellow=y
- ring-number: none=n,one=o,two=t
- ring-type: cobwebby=c,evanescent=e,flaring=f,large=l,none=n,pendant=p,sheathing=s,zone=z
- spore-print-color: black=k,brown=n,buff=b,chocolate=h,green=r,orange=o,purple=u,white=w,yellow=y
- population: abundant=a,clustered=c,numerous=n,scattered=s,several=v,solitary=y
- habitat: grasses=g,leaves=l,meadows=m,paths=p,urban=u,waste=w,woods=d

## Model Generation

To generate this model open a terminal instance to this directory and run `mlnet classification --dataset .\mushroom-data-trimmed.csv --label-col 0`

Note - When running this generation on the full data it was identified that ML.NET ran into formatting exceptions on the `cap-surface` column.
