/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

const [w, h, countX, countY] = readline().split(' ').map(Number);

const xInputs = readline().split(' ').map(Number);

let xs = [w, ...xInputs].sort((a, b) => b - a);

const xDiffs = [];
const yDiffs = [];

for (let i = 1; i < xs.length; i++) {
  const x = xs[i];

  for (let j = 0; j < i; j++) {
    const prevX = xs[j];

    xDiffs.push(prevX - x);
  }
}

xs = xs.concat(xDiffs)

var yInputs = readline().split(' ').map(Number);

let ys = [h, ...yInputs].sort((a, b) => b - a);

for (let i = 1; i < ys.length; i++) {
  const y = ys[i];

  for (let j = 0; j < i; j++) {
    const prevY = ys[j];

    yDiffs.push(prevY - y);
  }
}

ys = ys.concat(yDiffs);

let result = 0;

for (let i = 0; i < xs.length; i++) {
  const x = xs[i];

  for (let j = 0; j < ys.length; j++) {
    const y = ys[j];

    if (x === y) {
      result++;
    }
  }
}

console.log(result);
