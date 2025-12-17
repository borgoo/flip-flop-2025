### Day 3 — Bush Salesman

- **Puzzle link**: `https://flipflop.slome.org/2025/3`

### Puzzle 3: Bush Salesman
A Bush Salesman has a job for you: they want your help with their sales They have a list of bushes they want to sell, and they want you to check how many of them can be sold.

The list of bushes (your puzzle input) consists of a series of bushes, each represented by a color. The color of a bush is represented by three numbers, each ranging from 10 to 99. The first number represents the amount of red in the bush, the second number represents the amount of green, and the third number represents the amount of blue. Each number is separated by a comma.
You could say that the color of a bush is an RGB value. (although the range is 10 to 99 instead of 0 to 255)

For example:

Input:

```
10,20,30
20,10,30
30,20,10
10,50,10
50,10,50
10,20,30
```

This input has 6 bushes, some of which may share the same color.

The salesman wants to know what is the most common color in the list of bushes.
In the example above, each bush is unique, except for the first and last bush, which are the same color. The answer here is 10,20,30.

Which color appears most frequently in the full list? (your answer must be the full color separated by commas and no spaces)

**Your answer**: 96,81,67

### Part 2 — Color coded
The salesman is happy with your work, but they have another request.

> "Can you help me label my bushes based on the color?" they ask. "I label them Red, Green, Blue or Special."

A bush is labeled Red if the amount of red (the first number) is greater than both green and blue.
A bush is labeled Green if the amount of green (the second number) is greater than red and greater than blue.
A bush is labeled Blue if the amount of blue (the third number) is greater than red and greater than green.
A bush is labeled Special if 2 or more colors are equal.

For example:

Input:

```
10,20,30
20,10,30
30,20,10
10,50,10
50,10,50
10,20,30
```

This same input, but now labeled:

```
10,20,30: Blue
20,10,30: Blue
30,20,10: Red
10,50,10: Special
50,10,50: Special
10,20,30: Blue
```

Some notes:

When a bush is labeled as Special, it should not be labeled as Red, Green, or Blue. (being Special always takes priority)
Even if the amount of a color is bigger than the other two, it should still be labeled as Special if two or more colors are equal. (10,50,10 is special even if the green value is higher)
If all three colors are equal, the bush is also labeled as Special.
Because the salesman is unsure if the exotic bushes will sell well, tehy for now just wants to know how many bushes are labeled Green.

How many bushes are labeled "Green" in the full list?

**Your answer**: 774

### Part 3 — Colorful calculations
After you're done, the salesman is on the phone with a customer. After a while, they hang up and tells you with a smile that the customer wants to buy all the bushes.

Each bush's price depends on its color.
The prices are as follows:

Red bushes are 5 coins
Green bushes are 2 coins
Blue bushes are 4 coins
Special bushes are 10 coins
After labeling all the bushes, what is their total price in coins?

**Your answer**: 9662