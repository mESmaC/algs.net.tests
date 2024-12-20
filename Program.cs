﻿using algs.net.Sorting;
using algs.net.Utilities;

namespace algs.net.tests {
    public class Tests {
        public static void Main(string[] args) {
            while (true) {
                PrintMenu();

                string choice = Console.ReadLine();

                switch (choice) {
                    case "1":
                        RunTestWithClearAndPause(RunAllTests, "Run All Tests");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Exiting... Goodbye!");
                        return;
                    case "3":
                        RunTestWithClearAndPause(RunQuickSortTest, "QuickSort Test");
                        break;
                    case "4":
                        RunTestWithClearAndPause(RunBubbleSortTest, "BubbleSort Test");
                        break;
                    case "5":
                        RunTestWithClearAndPause(RunMergeSortTest, "MergeSort Test");
                        break;
                    case "6":
                        RunTestWithClearAndPause(RunInsertionSortTest, "InsertionSort Test");
                        break;

                    default:
                        PrintError("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    
        // Complexity and edge cases to demonstrate TTC (Time To Complete)
        private static int[] GenerateRandomArray(int size) {
            var random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++) {
                array[i] = random.Next(0, size);
            }
            return array;
        }

        private static int[] GenerateSortedArray(int size) {
            int[] array = new int[size];
            for (int i = 0; i < size; i++) {
                array[i] = i;
            }
            return array;
        }

        private static int[] GenerateReverseArray(int size) {
            int[] array = new int[size];
            for (int i = 0; i < size; i++) {
                array[i] = size - i;
            }
            return array;
        }
        // End of methods for complexity

        private static void PrintMenu() {
            Console.Clear();
            Console.WriteLine("=== Algs.NET Test Suite ===");
            Console.WriteLine("[1] Run All Tests");
            Console.WriteLine("[2] Exit");
            Console.WriteLine("[3] Run QuickSort Test");
            Console.WriteLine("[4] Run BubbleSort Test");
            Console.WriteLine("[5] Run MergeSort Test");
            Console.WriteLine("[6] Run InsertionSort Test");
            Console.Write("\nEnter your choice: ");
        }

        private static void RunTestWithClearAndPause(Action testMethod, string testName) {
            Console.Clear();
            Console.WriteLine($"=== {testName.ToUpper()} ===\n");
            testMethod();
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void RunAllTests() {
            Console.WriteLine("Running all tests...\n");
            RunQuickSortTest();
            RunBubbleSortTest();
            RunMergeSortTest();
            RunInsertionSortTest();
            Console.WriteLine("\nAll tests completed.");
        }

        private static void PrintError(string message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n*** {message} ***");
            Console.ResetColor();
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        // Add more test methods here for additional algorithms
        // Example:
        // private static void RunBinarySearchTest() { ... }

        private static void RunQuickSortTest() {
            Console.WriteLine("QuickSort Execution:");

            int[] smallArray = { 8, 3, 1, 7, 0, 10, 2 };
            Console.WriteLine("\nSorting Small Array:");
            Metrics.MeasureExecutionTimeAndMemory("QuickSort (Small Array)", () =>
            {
                QuickSort.Sort(smallArray);
            });
            Console.WriteLine("Sorted Array: " + string.Join(", ", smallArray));

            int[] largeArray = GenerateRandomArray(10000);
            Console.WriteLine("\nSorting Large Random Array:");
            Metrics.MeasureExecutionTimeAndMemory("QuickSort (Large Random Array)", () =>
            {
                QuickSort.Sort(largeArray);
            });

            int[] sortedArray = GenerateSortedArray(10000);
            Console.WriteLine("\nSorting Already Sorted Array:");
            Metrics.MeasureExecutionTimeAndMemory("QuickSort (Sorted Array)", () =>
            {
                QuickSort.Sort(sortedArray);
            });

            int[] reverseArray = GenerateReverseArray(10000);
            Console.WriteLine("\nSorting Reverse Sorted Array:");
            Metrics.MeasureExecutionTimeAndMemory("QuickSort (Reverse Sorted Array)", () =>
            {
                QuickSort.Sort(reverseArray);
            });

            Console.WriteLine("\n ==== ==== ==== ====\n");
        }

        private static void RunBubbleSortTest() {
            Console.WriteLine("BubbleSort Execution:");

            int[] smallArray = { 8, 3, 1, 7, 0, 10, 2 };
            Console.WriteLine("\nSorting Small Array:");
            Metrics.MeasureExecutionTimeAndMemory("BubbleSort (Small Array)", () =>
            {
                BubbleSort.Sort(smallArray);
            });
            Console.WriteLine("Sorted Array: " + string.Join(", ", smallArray));

            int[] largeArray = GenerateRandomArray(10000);
            Console.WriteLine("\nSorting Large Random Array:");
            Metrics.MeasureExecutionTimeAndMemory("BubbleSort (Large Random Array)", () =>
            {
                BubbleSort.Sort(largeArray);
            });

            int[] sortedArray = GenerateSortedArray(10000);
            Console.WriteLine("\nSorting Already Sorted Array:");
            Metrics.MeasureExecutionTimeAndMemory("BubbleSort (Sorted Array)", () =>
            {
                BubbleSort.Sort(sortedArray);
            });

            int[] reverseArray = GenerateReverseArray(10000);
            Console.WriteLine("\nSorting Reverse Sorted Array:");
            Metrics.MeasureExecutionTimeAndMemory("BubbleSort (Reverse Sorted Array)", () =>
            {
                BubbleSort.Sort(reverseArray);
            });

            Console.WriteLine("\n ==== ==== ==== ====\n");
        }

        private static void RunMergeSortTest() {
            Console.WriteLine("MergeSort Execution:");

            int[] smallArray = { 8, 3, 1, 7, 0, 10, 2 };
            Console.WriteLine("\nSorting Small Array:");
            Metrics.MeasureExecutionTimeAndMemory("MergeSort (Small Array)", () => {
                MergeSort.Sort(smallArray);
            });
            Console.WriteLine("Sorted Array: " + string.Join(", ", smallArray));

            int[] largeArray = GenerateRandomArray(10000);
            Console.WriteLine("\nSorting Large Random Array:");
            Metrics.MeasureExecutionTimeAndMemory("MergeSort (Large Random Array)", () => {
                MergeSort.Sort(largeArray);
            });

            int[] sortedArray = GenerateSortedArray(10000);
            Console.WriteLine("\nSorting Already Sorted Array:");
            Metrics.MeasureExecutionTimeAndMemory("MergeSort (Sorted Array)", () => {
                MergeSort.Sort(sortedArray);
            });

            int[] reverseArray = GenerateReverseArray(10000);
            Console.WriteLine("\nSorting Reverse Sorted Array:");
            Metrics.MeasureExecutionTimeAndMemory("MergeSort (Reverse Sorted Array)", () => {
                MergeSort.Sort(reverseArray);
            });

            Console.WriteLine("\n ==== ==== ==== ====\n");
        }

        private static void RunInsertionSortTest() {
            Console.WriteLine("InsertionSort Execution:");

            int[] smallArray = { 8, 3, 1, 7, 0, 10, 2 };
            Console.WriteLine("\nSorting Small Array:");
            Metrics.MeasureExecutionTimeAndMemory("InsertionSort (Small Array)", () => {
                MergeSort.Sort(smallArray);
            });
            Console.WriteLine("Sorted Array: " + string.Join(", ", smallArray));

            int[] largeArray = GenerateRandomArray(10000);
            Console.WriteLine("\nSorting Large Random Array:");
            Metrics.MeasureExecutionTimeAndMemory("InsertionSort (Large Random Array)", () => {
                MergeSort.Sort(largeArray);
            });

            int[] sortedArray = GenerateSortedArray(10000);
            Console.WriteLine("\nSorting Already Sorted Array:");
            Metrics.MeasureExecutionTimeAndMemory("InsertionSort (Sorted Array)", () => {
                MergeSort.Sort(sortedArray);
            });

            int[] reverseArray = GenerateReverseArray(10000);
            Console.WriteLine("\nSorting Reverse Sorted Array:");
            Metrics.MeasureExecutionTimeAndMemory("InsertionSort (Reverse Sorted Array)", () => {
                MergeSort.Sort(reverseArray);
            });

            Console.WriteLine("\n ==== ==== ==== ====\n");
        }


    }
}
