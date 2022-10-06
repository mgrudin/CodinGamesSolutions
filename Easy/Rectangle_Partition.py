import sys
import math

# Auto-generated code below aims at helping you parse
# the standard input according to the problem statement.

w, h, count_x, count_y = [int(i) for i in input().split()]
widths = [w]
w_diff = []
w_dict = {}
heights = [h]
h_diff = []
h_dict = {}
count = 0

for i in input().split():
    x = int(i)
    widths.append(x)

widths.sort(reverse=True)

for i in range(1, len(widths)):
    for j in range(0, i):
            w_diff.append(widths[j] - widths[i])

widths += w_diff
widths.sort()

for w in widths:
    if w not in w_dict.keys():
        w_dict[w] = 1
    else:
        w_dict[w] += 1

for i in input().split():
    y = int(i)
    heights.append(y)

heights.sort(reverse=True)
for i in range(1, len(heights)):
    for j in range(0, i):
            h_diff.append(heights[j] - heights[i])

heights += h_diff
heights.sort()

for h in heights:
    if h not in h_dict.keys():
        h_dict[h] = 1
    else:
        h_dict[h] += 1

for x in w_dict:
    if x in h_dict.keys():
        count += w_dict[x] * h_dict[x]

print(count)
