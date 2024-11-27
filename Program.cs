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
                        RunTestWithClearAndPause(RunBubbleSortTest, "BubbleSort Test");
                        break;
                    case "3":
                        RunTestWithClearAndPause(RunAllTests, "Run All Tests");
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Exiting... Goodbye!");
                        return;
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
            Console.WriteLine("[1] Run QuickSort Test");
            Console.WriteLine("[2] Run BubbleSort Test");
            Console.WriteLine("[3] Run All Tests");
            Console.WriteLine("[4] Exit");
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
            Console.WriteLine("QuickSort Execution:");

            // Small array
            int[] smallArray = { 8, 3, 1, 7, 0, 10, 2 };
            Console.WriteLine("\nSorting Small Array:");
            Metrics.MeasureExecutionTimeAndMemory("QuickSort (Small Array)", () =>
            {
                QuickSort.Sort(smallArray);
            });
            Console.WriteLine("Sorted Array: " + string.Join(", ", smallArray));

            // Large random array
            int[] largeArray = GenerateRandomArray(10000);
            Console.WriteLine("\nSorting Large Random Array:");
            Metrics.MeasureExecutionTimeAndMemory("QuickSort (Large Random Array)", () =>
            {
                QuickSort.Sort(largeArray);
            });

            // Already sorted array
            int[] sortedArray = GenerateSortedArray(10000);
            Console.WriteLine("\nSorting Already Sorted Array:");
            Metrics.MeasureExecutionTimeAndMemory("QuickSort (Sorted Array)", () =>
            {
                QuickSort.Sort(sortedArray);
            });

            // Reverse sorted array
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

            // Small array
            int[] smallArray = { 8, 3, 1, 7, 0, 10, 2 };
            Console.WriteLine("\nSorting Small Array:");
            Metrics.MeasureExecutionTimeAndMemory("BubbleSort (Small Array)", () =>
            {
                BubbleSort.Sort(smallArray);
            });
            Console.WriteLine("Sorted Array: " + string.Join(", ", smallArray));

            // Large random array
            int[] largeArray = GenerateRandomArray(10000);
            Console.WriteLine("\nSorting Large Random Array:");
            Metrics.MeasureExecutionTimeAndMemory("BubbleSort (Large Random Array)", () =>
            {
                BubbleSort.Sort(largeArray);
            });

            // Already sorted array
            int[] sortedArray = GenerateSortedArray(10000);
            Console.WriteLine("\nSorting Already Sorted Array:");
            Metrics.MeasureExecutionTimeAndMemory("BubbleSort (Sorted Array)", () =>
            {
                BubbleSort.Sort(sortedArray);
            });

            // Reverse sorted array
            int[] reverseArray = GenerateReverseArray(10000);
            Console.WriteLine("\nSorting Reverse Sorted Array:");
            Metrics.MeasureExecutionTimeAndMemory("BubbleSort (Reverse Sorted Array)", () =>
            {
                BubbleSort.Sort(reverseArray);
            });

            Console.WriteLine("\n ==== ==== ==== ====\n");
        }


    }
}
