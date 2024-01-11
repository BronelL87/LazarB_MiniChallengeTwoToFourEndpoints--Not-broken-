Bronel Lazar

1/10/2024

MiniChallengeTwoToFour - Endpoints

Created 3 endpoints for adding 2 numbers together with data validation, another that accepts 2 inputs one being your name and time you woke up, which then returns a sentence saying who you are and the time you woke up. Then a last endpoint that determines if a number is greater than, less than, or equal to another number (with validation). in a c# api

Peer reviewed by: Jerrod Packard
Peer notes: Nice work Bronel! I tested your endpoints in both Swagger and Postman and I got results from each platform. Your Time endpoint and your Add endpoint are both great. Your Greater Or Less endpoint has a few problems with the output that I have listed below. Those should be easy fixes though. Other than that, nice work!

Greater than or Less than: Your output should always have the first number first. (i.e. numOne is greater than numTwo. Or numOne is less than numTwo). You may also want to change the output when the two numbers are equal to each other. You could just say numOne is equal to numTwo and numTwo is equal to numOne.