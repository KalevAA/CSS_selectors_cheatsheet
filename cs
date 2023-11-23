<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>CSS selectors</title>
    <link rel="stylesheet" href="styles.css">
  </head>
  <body>
    <div class="Pealkiri">
    <h1>CSS selectors</h1></div>
    <div class="Kirjeldus">
    <p>In CSS, selectors are used to target the HTML elements on our web pages that we want to style. <br>
    There are a wide variety of CSS selectors available, allowing for fine-grained precision when selecting elements to style.</p></div>
   <div class="Tabel"><table class="tablecentre">
        <tr class="frontrow"> 
          <td>Selector</td>
          <td>What does it do?</td>
          <td>How does it look like in CSS?</td>
        </tr>
        <tr> 
          <td>Type selector</td>
          <td>Type selectors target an HTML element such as an <span>&lt;h1&gt;</span></td>
          <td>h1 {
        }</td>
        </tr>
        <tr> 
            <td>Class selector</td>
            <td>Class selectors target an element that has a specific value for its class attribute</td>
            <td>.box {
            }</td>
          </tr>
          <tr> 
            <td>ID selector</td>
            <td>ID selectors target an element that has a specific value for its id attribute</td>
            <td>#unique {
            }</td>
          </tr>
          <tr> 
            <td>Attribute selector</td>
            <td>This group of selectors gives you different ways to select elements based on the presence of a certain attribute on an element</td>
            <td>a[title] {
            } or a[href="https://example.com"]
            {
            }</td>
          </tr>
          <tr> 
            <td>Pseudo-class and Pseudo element</td>
            <td>This group of selectors includes pseudo-classes, which style certain states of an element. The :hover pseudo-class for example selects an element only when it is being hovered over by the mouse pointer.
                It also includes pseudo-elements, which select a certain part of an element rather than the element itself. For example, ::first-line always selects the first line of text inside an element (a <span>&lt;p&gt;</span>in the below case), acting as if a <span>&lt;spanss&gt;</span> was wrapped around the first formatted line and then selected.

            </td>
            <td>a:hover {
            } or p::first-line {
            }</td>
          </tr>
          <tr> 
            <td>Combinator</td>
            <td>The final group of selectors combine other selectors in order to target elements within our documents. The following, for example, selects paragraphs that are direct children of <span>&lt;article&gt;</span> elements using the child combinator (>):</td>
            <td>article > p {
            }</td>
          </tr>
      </table></div> 
  </body>
</html>
