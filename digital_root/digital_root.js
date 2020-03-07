function digital_root(n) {
  let arr = Array.from(String(n), Number);
  let sum = 0;
  for (let i = 0; i < arr.length; i++) {
    sum += arr[i];
  }
  return sum < 10 ? sum : digital_root(sum);
}
