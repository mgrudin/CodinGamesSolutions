import sys
import math

# Auto-generated code below aims at helping you parse
# the standard input according to the problem statement.

w, h, count_x, count_y = [int(i) for i in input().split()]
widths = [w]
w_diff = []
heights = [h]
h_diff = []
count = 0

for i in input().split():
    x = int(i)
    for i in widths:
        if i < x:
            w_diff.append(x - i)
        else:
            w_diff.append(i - x)
    widths.append(x)
widths += w_diff

for i in input().split():
    y = int(i)
    for i in heights:
        if i < y:
            h_diff.append(y - i)
        else:
            h_diff.append(i - y)
    heights.append(y)
heights += h_diff

for x in widths:
    for y in heights:
        if x == y: count += 1

print(count)