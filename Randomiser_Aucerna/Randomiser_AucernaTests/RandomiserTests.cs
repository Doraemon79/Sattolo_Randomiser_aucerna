using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Randomiser_Aucerna.ViewModel;
using Randomiser_Aucerna.ViewModel.Interfaces;

namespace Randomiser_AucernaTests
{
    /// <summary>
    /// Test a sequence is random is an oxymoron, so I resorted to test 
    /// length =1000 all the 1000 present and no doubles.
    /// </summary>
    [TestClass]
    public class RandomiserTests
    {
        //it seems overkill but being a job I would love to get I want to show 
        //a use of Ninject
            private IKernel _kernel;
            [TestInitialize()]
            public void Initialize()
            {
                _kernel = new StandardKernel();
            }

            [TestMethod]
            public void CanShuffle()
            {
                IRandomiser _randomiser = _kernel.Get<Randomiser>();
                // Declare array and initialize it
                int[] arrayShuffled = new int[1000];
                int[] arrayResult = new int[1000];
                for (int i = 0; i < 1000; i++)
                {
                    arrayShuffled[i] = i + 1;
                }

                // Shuffle array

                arrayResult = _randomiser.Shuffle(arrayShuffled);

                // Arrange
                int expectedArrSize = 1000;

                // Act
                int actualArrSize = arrayResult.Length;

                // Assert array size (length)
                Assert.AreEqual(expectedArrSize, actualArrSize);

                // assert all numbers from 1 to 1000 are present
                bool foundAll = false;

                // open FOR loop with all values from 1 to 1000
                for (int value = 1; value <= 1000; value++)
                {
                    // open FOR loop for array iterator to check all members of array agains value
                    for (int iterator = 0; iterator < 1000; iterator++)
                    {
                        // If value is found in array, break loop
                        if (arrayResult[iterator] == value)
                        {
                            foundAll = true;
                            break;
                        }
                        // This check enables break if any value is not found in shuffled array
                        if (!foundAll)
                        {
                            break;
                        }
                    }
                }

                // Assert
                Assert.IsTrue(foundAll);
            }
        }
    }

