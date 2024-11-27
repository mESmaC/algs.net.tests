using System;
using algs.net.Sorting;
using algs.net.Utilities;

namespace algs.net.tests {
    public class Tests {
        public static void Main(string[] args) {
            while (true) {
                PrintMenu();

                string choice = Console.ReadLine();

                switch (choice) {
                    case "1":
                        RunTestWithClearAndPause(RunQuickSortTest, "QuickSort Test");
                        break;
                    case "2":
                        RunTestWithClearAndPause(RunAllTests, "Run All Tests");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Exiting... Goodbye!");
                        return;
                    default:
                        PrintError("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void PrintMenu() {
            Console.Clear();
            Console.WriteLine("=== Algs.NET Test Suite ===");
            Console.WriteLine("[1] Run QuickSort Test");
            Console.WriteLine("[2] Run All Tests");
            Console.WriteLine("[3] Exit");
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
            // Add calls to other test methods here as they are implemented
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
            int[] numbers = { 8, 3, 1, 7, 0, 10, 2 };
            Console.WriteLine("QuickSort Execution:");
            Metrics.MeasureExecutionTime("QuickSort", () => {
                QuickSort.Sort(numbers);
            });
            Console.WriteLine("Sorted Array: " + string.Join(", ", numbers));
        }
    }
}
