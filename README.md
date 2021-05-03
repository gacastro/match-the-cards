# Match the cards
Application to simulate a card game called "Match!" between two computer players.

- [Match the cards](#match-the-cards)
  - [Game Rules](#game-rules)
    - [Game Setup](#game-setup)
    - [Playing the game](#playing-the-game)
    - [Match condition](#match-condition)
  - [The program](#the-program)
    - [How to run](#how-to-run)
  - [Considerations](#considerations)
  - [Future Improvements](#future-improvements)

## Game Rules
### Game Setup
Choose a number of packs of [playing cards](https://en.wikipedia.org/wiki/Standard_52-card_deck), and combine them into a single *deck*. Shuffle the deck.
Choose the match condition (see bellow)

### Playing the game
Cards are played sequentially from the top of the deck into the *pile*.

If two cards played sequentially *match* (see "Match condition" below), the first player to declare "Match!" takes all the cards in the pile. *For the purposes of this simulation, the program should choose a random player as having declared "Match!" first.*

Play then continues with the next card in the deck, starting a new pile. The game ends when no more cards can be drawn from the deck and no player can declare "Match!". (Any remaining cards in the pile may be discarded.)

The player that has taken the most cards is the winner. The game may end in a draw.

### Match condition

The match condition determines when two cards *match* for the duration of the game. There are three options:

- The **suits** of two cards must match
    - Example: "3 of hearts" and "5 of hearts" match because they are both **hearts**.
- The **values** of two cards must match
    - Example: "7 of hearts" and "7 of clubs" match because they both have the value **7**.
- **Both suit and value** must match
    - Example: "Jack of spades" **only matches** another "Jack of spades"


## The program
As input, the program should ask:

1. how many packs of cards to use for the deck
1. which *match condition* to use

It should then simulate the game.

The program should output the results by either declaring the winner, or a draw.

### How to run
.Net core needs to be installed in your machine.

From your command line navigate to the root folder of the application and:

```
> cd Code
> dotnet run --n 2 --c 1
```
Please bear in mind that `n` is the number of packs you wish to compose the deck with. It is constrained to `n > 0`.

And also notice that `c` is the condition you wish to match the cards on. It is constrained to:
* 1 - **suit** of two cards must match
* 2 - **value** of two cards must match
* 3 - **suit and value** of two cards must match

## Considerations
* We cannot assert how well the shuffling operation is because its not a predictable result.
* There are some parts of the code that are untested due to time they would take to right. I had to abandon my TDD approach but In future improvements I mention the tests I would have liked to do. And I'm sure there will be many others.

## Future Improvements
* Make an interactive experience for the user, where we'd ask for the inputs after displaying possibilities. And then ask if he'd like to play more and so on
* Continue the test pattern in `ValueCardsCounterTests` and `SuitAndValueCardsCounterTests`. Since most of the behaviours are similar in the card counters I'm fairly confident that if I had written the tests they would pass. Also believe that if they fail would be due to copy pasting gone rogue
* Tests on picking the winner.
* Refctor `SuitAndValueCardsCounter` whith generics. Most of that code is copy pasting so I believe there is a less agressive way to write it with generics
