# Coding Challenge 399

Repository for challenge build automation. Took inspiration from [Reddit Daily Challenge #399](https://www.reddit.com/r/dailyprogrammer/comments/onfehl/20210719_challenge_399_easy_letter_value_sum/).

For italian friends, read [here](#italiano)

**Table of Contents**:
* [Instructions](#instructions)
* [Challenge](#challenge)
* [Contributions](#contributions)

## Instructions

1. Fork this repository
2. Read the [challenge](#challenge)
3. Write code in functions inside _Program.cs_ file
3. Open a pull request to the forked repo

The results will be uploaded to [Github Pages](https://daniele-tentoni.github.io/coding-challenge-399/).

## Challenge

Assign every lowercase letter a value, from 1 for a to 26 for z. Given a string of lowercase letters, find the sum of the values of the letters in the string.

```
lettersum("") => 0
lettersum("a") => 1
lettersum("z") => 26
lettersum("cab") => 6
lettersum("excellent") => 100
lettersum("microspectrophotometries") => 317
```

### Optional bonus challenges

! Use the enable1 word list for the optional bonus challenges.

Hint: successive challenges may share some code with previous ones.

1. microspectrophotometries is the only word with a letter sum of 317. Find the only word with a letter sum of 319.
2. How many words have an odd letter sum?
3. There are 1921 words with a letter sum of 100, making it the second most common letter sum. What letter sum is most common, and how many words have it?
4. zyzzyva and biodegradabilities have the same letter sum as each other (151), and their lengths differ by 11 letters. Find the other pair of words with the same letter sum whose lengths differ by 11 letters.
5. cytotoxicity and unreservedness have the same letter sum as each other (188), and they have no letters in common. Find a pair of words that have no letters in common, and that have the same letter sum, which is larger than 188. (There are two such pairs, and one word appears in both pairs.)

**Bonus of Bonus**:

This is god level! There's no a response.

1. The list of word { geographically, eavesdropper, woodworker, oxymorons } contains 4 words. Each word in the list has both a different number of letters, and a different letter sum. The list is sorted both in descending order of word length, and ascending order of letter sum. What's the longest such list you can find?

(This challenge is a repost of Challenge #52 [easy], originally posted by u/rya11111 in May 2012.)

## Contributions

The challenge score update script support only CSharp code base. If you want to support another language, let me know it.

# Italiano

**Tabella dei Contenuti**:

* [Istruzioni](#istruzioni)
* [Sfida](#sfida)
* [Contribuzioni](#contribuzioni)

## Istruzioni

1. Forka questo repository
2. Leggi la [sfida](#sfida)
3. Scrivi il codice dentro al file _Program.cs_ se vuoi affrontare la sfida usando CSharp, il file program.sh per script sh
3. Apri una pull request al repository padre

I risultati saranno caricati su [Github Pages](https://daniele-tentoni.github.io/coding-challenge-399/).

## Sfida

Assegna ad ogni carattere minuscolo un valore da 1 per _a_ a 26 per _z_. Data una stringa di caratteri minuscoli, calcola la somma dei valori delle lettere nella stringa.

```
lettersum("") => 0
lettersum("a") => 1
lettersum("z") => 26
lettersum("cab") => 6
lettersum("excellent") => 100
lettersum("microspectrophotometries") => 317
```

### Sfide bonus opzionali

! Usa il file enable1 per completare le sfide.

Indizio: sfide successive potrebbero condividere codice con le precedenti.

1. microspectrophotometries e' l'unica parola la cui somma e' 317. Trova quella con somma 319.
2. Quante parole hanno una somma dispari? Quante pari?
3. Ci sono 1921 parole con somma 100, rendendo tale somma la seconda piu' comune. Quale e' quella piu' comune? Quante parole ha?
4. zyzzyva e biodegradabilities hanno la stessa somma, ma la loro lunghezza differisce di 11 caratteri. Trova l'altro paio di parole con la stessa somma di lettere ma con lunghezza che differisce di 11 caratteri.
5. cytotoxicity e unreservedness hanno la stessa somma di lettere (188), ma non hanno lettere in comune. Trova un altro paio di di parole che non hanno lettere in comune ma che hanno la stessa somma, che deve essere maggiore di 188 (ci sono altre 2 paia, e una parola compare in entrambe).

**Bonus del Bonus**:

Questa e' al livello massimo! Non c'e' una risposta.

1. La lista di parole { geographically, eavesdropper, woodworker, oxymorons } contiene 4 parole.Ogni parola nella lista ha una differente somma e un differente numero di lettere. La lista e' ordinata per lunghezza della parola discendente e per somma ascendente. Quale e' la lunghezza di tale lista?

(Questa sfida e' un repost della Challenge #52 [easy], postata originariamente da u/rya11111 nel Maggio 2012.)

## Contribuzioni

Se vuoi supportare un altro linguaggio per portare a termine questa sfida, fammelo sapere. Attualmente supporto solamente il CSharp.
