#!/usr/bin/env python3

import os
import sys

def sed() -> None:
  score_path = os.path.join(".", "score.txt")
  try:
    with open(score_path, "r") as score_file:
      scores = score_file.readline()
      score = scores.split("::")
      score_parts = len(score)
      if score_parts < 4:
        print(f"Score file missing some parts {4 - score_parts}")
        exit(1)
  except OSError as e:
    print(f"Error during reading scores {e}")
    exit(1)

  lines = []
  missing = True
  try:
    with open("dist/standings.txt", 'r') as r:
      for line in r.readlines():
        comps = line.split("::")
        if comps[0] == score[0]:
          lines.append(score) # Slice the first elem or scores
          missing = False
        else:
          lines.append(comps)
  except OSError as e:
    print(f"Error during reading standings {e}")
    exit(1)

  if missing:
    lines.append(score)
    missing = False

  standings = [s for s in sorted(lines, key=lambda x: (x[1], x[2]),reverse=True)]
  try:
    with open("dist/standings.txt", "w") as w:
      for s in standings:
        w.write("::".join(s))
  except OSError as e:
    print(f"Error during writing standings {e}")
    exit(1)

if __name__ == "__main__":
  if len(sys.argv) > 1:
    print(f"Run this command without arguments")
    exit(1)
  sed()
