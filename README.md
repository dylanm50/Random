# Random
This is a simple demonstration that generates *n* unique random numbers of max size *l - 1* and min size 0. Each random number will be stored in an array *a*.

The way it works is each random number is generated with a range of (*( l / n )i* - *( l / n )( i + 1 ) - 1* ) where *i* is the index of the number.

This effectivly chops *l* into discrete chunks which the random numbers are pulled from.

In this demonstration *l* and *n* are both set to 10 to demonstrate that no matter what each random number will be unique as long as *n* <= *l* but of course in real use you would set these to be different values.

This algorithm works particularly well when you want to get different items out of an array. If you are worried that each output will only pull from a certain range in the array you can always either shuffle the output array or shuffle the input array!
