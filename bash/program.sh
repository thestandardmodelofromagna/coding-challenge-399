#!/usr/bin/env bash

function lettersum {
  # $1 param contains the word to process

  # Write here the code for step 0
  lettersum_result=-1
}

function single_word_with_given_letter_sum {
  # $1 param contains the length to search

  # Write here the code for step 1
  single_word=""
}

function num_of_odd_sum {
  # Write here the code for step 2

  odd_sums=-1
}

function num_of_even_sum {
  # Write here the code for step 2

  even_sums=-1
}

function most_common_letter_sum {
  # Write here the code for step 3

  most_common_sum="n,n"
}

function same_sum_differ_length {
  # Write here the code for step 4

  same_sum_differ_length_result="w,w"
}

function same_sum_no_common_letters {
  # Write here the code for step 5

  same_sum_no_common_letters_result="w1,w1,w2,w2"
}

# Read file content
# Read here a file and manipulate it as your pleasure

# Don't modify those lines for the challenge, at your own risk!

# Execute functions
score=0

function check_fun {
  lettersum $1
  [[ $lettersum_result -eq $2 ]] && ((score=score+1))
}

check_fun "" 0
check_fun "a" 1
check_fun "z" 26
check_fun "cab" 6
check_fun "excellent" 100
check_fun "microspectrophotometries" 317

single_word_with_given_letter_sum 319
[[ $single_word == "reinstitutionalizations" ]] && ((score=score+1))

num_of_odd_sum
[[ $odd_sums == 86339 ]] && ((score=score+1))
num_of_even_sum
[[ $even_sums == 86485 ]] && ((score=score+1))

most_common_letter_sum
[[ $most_common_sum == "93,1965" ]] && ((score=score+1))

same_sum_differ_length
[[ $same_sum_differ_length_result == "electroencephalographic,voluptuously" ]] && ((score=score+1))

same_sum_no_common_letters
[[ $same_sum_no_common_letters_result == "defenselessnesses,microphotographic,defenselessnesses,photomicrographic" ]] && ((score=score+1))

# Echo the score of the challenge
echo $score
