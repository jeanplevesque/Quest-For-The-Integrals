# Quest For The Integrals
A legacy console game project ported to .NET 8 from .NET Framework 3.5.

![Screenshot](/doc/screenshot.png)

## Project History
Started in 2009, this project is a turn-based game inspired by _Heroes of Might and Magic III_. You build an army of units and fight in a 2D grid-like arena.

This project features great things from my programming debut, such as ASCII art, `Console.Beep` music, and non-English code.
> However since the `Console.Beep` API is somewhat deprecated (it just doesn't sound as good as it used to), I replaced them with a `SoundPlayer`-based alternative.

The title (and intro image) are totally unrelated to the gameplay. They were inspired by my math teacher of the time.

## Playing the game
To run the game, simply clone the code and run it. It's a simple console application with almost no dependency.

### Disclaimers
- The game is in French.
- The performance of drawing on the console has somehow decreased over the years so the combat movements is really flickery and janky. It's so unpleasant to watch that I might fix it.
- You can't really win the game. You can always move on to a next combat. It just never ends.

### Tips
- I strongly recomment playing the tutorial because the controls are far from being obvious.
- When buying units, you can type `max` instead of a number to buy as many of that unit type possible, based on your gold.