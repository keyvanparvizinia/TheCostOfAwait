# TheCostOfAwait
What is the cost of awaiting? How much can you save if you elide the "await" keyword?

The short answer: In 99% of cases that is the wrong question. Yes there is a cost to the state machine that gets created behind the scenes - that is undoubtable and yes there are certain costs attached to that.

![AwaitVsElide](https://github.com/parvizi-k1/TheCostOfAwait/assets/67179955/65167ff0-92e8-4cd5-ad1c-47b01d038eac)
