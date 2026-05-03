# Lecture 05: Constructing a Compelete Web Page with HTML

## Introduction

Building a web page with HTML involves setting up a clear structure and organizing content effectively. This guide will walk you through the basic steps of creating a web page, from structuring the HTML document to adding essential elements like text, lists, and links.

## Step 1: Set Up the Basic HTML Structure

1. Declare HTML5 by adding `<!DOCTYPE html>` at the top of your file.
2. Start the HTML Document using `<html>` tags. Everything within this tag makes up your web page.
3. Add the Head Section: Inside `<html>`, include a `<head>` tag to hold metadata such as:
	- `<title>`: Defines the title that appears in the browser tab.
	- `<meta charset="UTF-8">`: Ensures proper text encoding.
	- `<link>`: Connect to external CSS files if necessary.
4. Create the Body Section: Inside `<body>`, this is where all visible content goes.

## Step 2: Add and Structure Text

1. Headings: Use `<h1>` to `<h6>` tags to create a title hierarchy. `<h1>` is the most important (main heading), while `<h6>` is the least important.

Example:

```html
<h1>Main Title</h1>
<h2>Section Title</h2>
```

2\. Paragraphs: Wrap blocks of text in `<p>` tags to organize ideas and make the content easy to read.

Example:

```html
<p>This is a paragraph of text.</p>
```

## Step 3: Create Lists

1. Ordered Lists: Use `<ol>` to create numbered lists, and add items using `<li>`.
	- Example:

```html
<ol>
<li>First item</li>
<li>Second item</li>
</ol>
```

2\. Unordered Lists: Use <ul> for bulleted lists, with each list item wrapped in <li>.

- Example:

<ul>

<li>First item</li>

<li>Second item</li>

</ul>

3\. Nested Lists: To create sub-lists, simply place a new `<ul>` or `<ol>` within an existing list.

- Example:

```html
<ul>
<li>Main item
<ul>
<li>Sub-item</li>
</ul>
</li>
</ul>
```

## Step 4: Add Links

1\. External Links: Use the `<a>` tag with the `href` attribute to link to other websites.

- Example:

```html
<a href="https://example.com">Visit Example.com</a>
```

2\. Internal Links: To navigate within the same page, use an anchor link with a # followed by the ID of the target section.

- Example:

```html
<a href="#section1">Go to Section 1</a>
```

## Conclusion

Following these steps, you can structure a basic HTML web page and add essential content elements such as text, lists, and links. Mastering these fundamentals ensures that your web pages are well-organized, accessible, and easy for users to navigate.
