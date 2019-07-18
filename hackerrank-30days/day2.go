package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

func main() {
	var _ = strconv.Itoa // Ignore this comment. You can still use the package "strconv".

	var i int = 4
	var d float64 = 4.0
	var s string = "HackerRank "

	scanner := bufio.NewReader(os.Stdin)
	// Declare second integer, double, and String variables.
	var i2 int = 5
	var d2 float64 = 5.1
	var s2 string = "Ha Doan"
	// Read and save an integer, double, and String to your variables.
	fmt.Print("Enter integer: ")
	i2, _ = fmt.Scanf("%d", &i2)
	fmt.Print("Enter double: ")
	d2Str, _ := scanner.ReadString('\n')
	d2, _ = strconv.ParseFloat(d2Str, 64)
	fmt.Print("Enter string: ")

	s2, _ = scanner.ReadString('\n')

	// Print the sum of both integer variables on a new line.
	fmt.Println(i + i2)
	// Print the sum of the double variables on a new line.
	fmt.Println(d + d2)
	// Concatenate and print the String variables on a new line
	fmt.Println(s + s2)
	// The 's' variable above should be printed first.

}
