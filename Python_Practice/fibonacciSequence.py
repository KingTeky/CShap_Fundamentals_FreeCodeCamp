""" Demonstrating the use of Fibonacci sequence in various domains """

# 🌱 **1. Nature — Sunflower Spiral Simulation**
"""Simulate the sunflower seed pattern using the **golden angle** (derived from Fibonacci).
"""
import matplotlib.pyplot as plt
import math

# Golden angle in radians
golden_angle = math.radians(137.5)

points = 300
x_vals = []
y_vals = []

for n in range(points):
    r = math.sqrt(n)
    theta = n * golden_angle
    x_vals.append(r * math.cos(theta))
    y_vals.append(r * math.sin(theta))

plt.scatter(x_vals, y_vals, s=10)
plt.title("Sunflower Spiral (Fibonacci / Golden Angle)")
plt.axis("equal")
plt.show()


# 📐 **2. Golden Ratio — Fibonacci Ratio Convergence**
# You’ll see the ratio converge toward **1.618…**
""" Show how Fibonacci ratios approach φ.
"""

def fib(n):
    a, b = 0, 1
    for _ in range(n):
        a, b = b, a + b
    return a

for i in range(2, 12):
    print(f"F({i})/F({i-1}) = {fib(i)/fib(i-1)}")


# 💻 **3. Computer Science — Dynamic Programming Speedup**
# You’ll see a dramatic speed difference.
"""Compare slow recursion vs fast DP.
"""

from functools import lru_cache
import time

# Slow recursive Fibonacci
def slow_fib(n):
    if n < 2:
        return n
    return slow_fib(n-1) + slow_fib(n-2)

# Fast Fibonacci using memorization
@lru_cache(None)
def fast_fib(n):
    if n < 2:
        return n
    return fast_fib(n-1) + fast_fib(n-2)

n = 35

start = time.time()
slow_fib(n)
print("Slow recursion:", time.time() - start, "seconds")

start = time.time()
fast_fib(n)
print("Fast DP:", time.time() - start, "seconds")


# 📊 **4. Finance — Fibonacci Retracement Levels**
# Shows how traders compute Fibonacci-based support levels.
"""Simulate retracement levels for a price move.
"""
start_price = 100
end_price = 150
difference = end_price - start_price

levels = [0.236, 0.382, 0.618]

print("Fibonacci Retracement Levels:")
for lvl in levels:
    retracement = end_price - difference * lvl
    print(f"{lvl*100:.1f}% → {retracement}")


# 🎨 **5. Art & Design — Fibonacci Layout Grid**
"""Generate a Fibonacci-based UI grid. This produces a proportional layout used in design.
"""
import matplotlib.pyplot as plt

fib = [1, 1, 2, 3, 5, 8]

plt.figure(figsize=(10, 2))

x = 0
for width in fib:
    plt.gca().add_patch(plt.Rectangle((x, 0), width, 1, fill=False))
    x += width

plt.title("Fibonacci Layout Grid")
plt.axis("equal")
plt.show()


# 🧠 **6. Mathematics — Counting Binary Strings**
"""Count binary strings with no consecutive 1s (Fibonacci result). The output is Fibonacci numbers.
"""


def count_no_consecutive_ones(n):
    if n == 0: return 1
    if n == 1: return 2

    a, b = 1, 2  # F(1)=1, F(2)=2
    for _ in range(2, n+1):
        a, b = b, a + b
    return b

for n in range(1, 8):
    print(f"Length {n}: {count_no_consecutive_ones(n)} strings")


# 🌌 **7. Biology — Rabbit Population Simulation**
"""Simulate Fibonacci’s original rabbit problem. Classic Fibonacci growth"""

def rabbits(months):
    a, b = 1, 1
    for _ in range(months):
        yield a
        a, b = b, a + b

for month, count in enumerate(rabbits(10), start=1):
    print(f"Month {month}: {count} rabbit pairs")


# 🌳 **8. Tree Branching Simulation**
"""Simulate recursive branching using Fibonacci. Branch count follows Fibonacci numbers.
"""

def branches(n):
    if n <= 2:
        return n
    return branches(n-1) + branches(n-2)

for year in range(1, 8):
    print(f"Year {year}: {branches(year)} branches")

# END