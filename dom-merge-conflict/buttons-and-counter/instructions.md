# Buttons and Counter

This app currently features a button that increments a counter.

## Task for Person A

Create and switch to a new branch named `split-app-components`:

```
git switch -c split-app-components
```

### Task

Split the `header`, `main` into separate components from `app.js`.

- Separate the components into new functions that live in their own files.
- Make sure to use those functions in `app.js` so the end result remains the same, and tests still run.
- Remember - tests are your friend, run them before, during and after you've wrote some code. Use them to guide you.

### Tests

There are three tests that are _not_ skipped (lines 18 - 36 in `app.test.js`), use these tests to check your changes still let the app function as expected.

### Result

- You should end up with an `app.js` file, a `header.js` file, and a `main.js` file in your `src` directory.
- All tests should pass.

## Task for Person B

Create and switch to a new branch named `add-decrement-button`:

```
git switch -c add-decrement-button
```

### Task

Implement a decrement button.

- Read the skipped tests (lines 38-53 in `app.test.js`) before you start. You will use these tests to guide you.
- Write your code in `app.js`
- Update the description of the app in the `header` element.

### Tests

Tests (lines 38-53 in `app.test.js`) are pre-written but skipped, un-skip them and run the tests before, during and after you write your code.

### Result

Your `app.js` file will now contain a button that decrements the counter and all the tests will run and pass.
