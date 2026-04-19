# Hangman
## Overview  
This repo is for the software implementation of the classic game of Hangman. This software allows a single player to guess a hidden word chosen by the computer. A description of the game plus the requirements of this implementation are provided below.  

## The Game  
The player is presented with a hidden word, displayed as a series of blank spaces representing each letter. The player guesses one letter at a time by selecting from the available alphabet.  

If the guessed letter is in the word, all instances of that letter are revealed in their correct positions. If the guessed letter is not in the word, a part of the hangman figure is added.  

The player continues guessing letters until either:  
- the full word is correctly revealed, resulting in a win, or  
- the hangman figure is fully drawn after a set number of incorrect guesses, resulting in a loss.  
