using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Lib.Personal.Box
{
    public class Box
    {
        // Biggest dimension to smallest dimension
        private int[] dimensions;
        public int[] Dimensions
        {
            get
            {
                return dimensions;
            }
            set
            {
                dimensions = value;
                // Calculate vlume here so we don't have to do it over and over when we're checking
                volume = value.Aggregate(1, (x, y) => x * y);
            }
        }
        public int Mass { get; set; }
        public string Id { get; set; }
        public int volume;
        [IgnoreDataMember]
        public int Volume
        {
            get
            {
                return volume;
            }
        }
    }

    public class Package
    {
        // Biggest dimension to smallest dimension
        private int[] dimensions;
        public int[] Dimensions
        {
            get
            {
                return dimensions;
            }
            set
            {
                dimensions = value;
                // Calculate volume here so we don't have to do it over and over
                // when we're checking
                volume = value.Aggregate(1, (x,y) => x * y);
            }
        }

        public int MaxMass { get; set; }
        public int Price { get; set; }
        public string Id { get; set; }
        public int volume;
        [IgnoreDataMember]
        public int Volume
        {
            get
            {
                return volume;
            }
        }
    }

    public class Boxes
    {
        private Box[] boxArray;
        public Box[] BoxArray
        {
            get
            {
                return boxArray;
            }
            set
            {
                boxArray = value;
                totalMass = value.Sum(v => v.Mass);
                totalVolume = value.Sum(v => v.Volume);
            }
        }

        private int totalMass;
        [IgnoreDataMember]
        public int TotalMass
        {
            get
            {
                return totalMass;
            }
        }

        private int totalVolume;
        [IgnoreDataMember]
        public int TotalVolume
        {
            get
            {
                return totalVolume;
            }
        }
    }

    public class Packages
    {
        private Package[] packageArray;
        public Package[] PackageArray
        {
            get
            {
                return packageArray;
            }
            set
            {
                packageArray = value;
                totalMaxMass = value.Sum(v => v.MaxMass);
                totalVolume = value.Sum(v => v.Volume);
                totalPrice = value.Sum(v => v.Price);
            }
        }
        
        private int totalMaxMass;
        [IgnoreDataMember]
        public int TotalMaxMass
        {
            get
            {
                return totalMaxMass;
            }
        }

        private int totalVolume;
        [IgnoreDataMember]
        public int TotalVolume
        {
            get
            {
                return totalVolume;
            }
        }

        private int totalPrice;
        [IgnoreDataMember]
        public int TotalPrice
        {
            get
            {
                return totalPrice;
            }
        }
    }

    public class BoxSolution
    {
        public Box box { get; set; }
        int[] Position { get; set; }
        int Rotation { get; set; }
    }

    public class PackageSolution
    {
        public Package package { get; set; }
        public List<BoxSolution> boxSolutions { get; set; }
    }

    public class PackageSolutions
    {
        public List<PackageSolution> PackageSolutionList { get; set; }
    }

    public class Soltion
    {
        public static readonly int maxNumPackages = 5;
        public static readonly int defaultDimensions = 3;

        /// <summary>
        /// Given <param name="boxes", find the cheapest combination of packages from <paramref name="packageTypes"/>
        /// that would be able to hold them.
        /// 
        /// Return a PackageSolutions, which maps hte packages to which BoxSoluions fit inside them, where BoxSolution
        /// specify the coordinates a box is placed in a package
        /// </summary>
        /// <param name="packageTypes">Types of packages that can be posted</param>
        /// <param name="boxes">boxes to put into the packages</param>
        /// <returns></returns>
        public PackageSolutions GetCheapestPackagesForBoxes (Packages packageTypes, Boxes boxes)
        {
            foreach (var packages in GetCheapestPackagesInOrder(packageTypes.PackageArray))
            {
                if (CanTheoreticallyFit(packages, boxes))
                {
                    PackageSolutions packageSolutions = new PackageSolutions();

                    foreach (var package in packages.PackageArray)
                    {
                        PackageSolution packageSolution = new PackageSolution();
                        packageSolution.package = package;

                        packageSolutions.PackageSolutionList.Add(packageSolution);
                    }

                    return packageSolutions;
                }
            }

            throw new ArgumentException("No Solution");
        }

        public List<BoxSolution> GetBoxSolution(Package package, Span<BoxSolution> boxes, int boxIndex = 0, List<int[]> availablePositions = null)
        {
            throw new NotImplementedException();

            if (availablePositions == null)
            {
                availablePositions = new List<int[]>() { new int[boxes[0].box.Dimensions?.Length ?? defaultDimensions] };
            }

            foreach (var position in availablePositions)
            {
                if (CanBoxFit(package, boxes.Slice(0, boxIndex), boxes[boxIndex], position))
                {

                }
            }
        }

        public bool CanBoxFit(Package package, Span<BoxSolution> boxes, BoxSolution box, int[] position)
        {
            throw new NotImplementedException();
            // check box won't collide with package
        }

        /// <summary>
        /// Returns true if <paramref name="boxes"/> can theoretically fit in <paramref name="packages"/>
        /// 
        /// That is to say if dimensions of the box fits in at least one package, and the total mass
        /// of the boxes is less than the total mass allowance of the packages
        /// </summary>
        /// <param name="packages"></param>
        /// <param name="boxes"></param>
        /// <returns></returns>
        public bool CanTheoreticallyFit(Packages packages, Boxes boxes)
        {
            if (boxes.TotalMass > packages.TotalMaxMass
                || boxes.TotalVolume > packages.TotalVolume)
            {
                // Boxes weigh more than the packages can allow for, or boxes have more volume
                // than the packages
                return false;
            }

            // Check each box fits in at least one package
            foreach (var box in boxes.BoxArray)
            {
                bool fits = true;

                // Check each package against this box
                foreach (var package in packages.PackageArray)
                {
                    if (box.Mass > package.MaxMass)
                    {
                        fits = false;
                    }

                    // Check each dimension of hte box is smaller than the dimensions in package.
                    // DImensions are ordered largeset to smallest so we don't need to order them
                    for (int i = 0; i < box.Dimensions.Length; i++)
                    {
                        if (box.Dimensions[i] > package.Dimensions[i])
                        {
                            // Box is too big for this package, try the next one
                            fits = false;
                        }
                    }

                    // All dimensions were smaller than the package and mass less than package MaxMass
                    if (fits)
                    {
                        // box fit in this package, don't check anymore packages
                        break;
                    }
                }

                // Box didn't fit in any packages
                if (!fits)
                {
                    return false;
                }
            }

            return true;
        }

        public IEnumerable<Packages> GetCheapestPackagesInOrder(IEnumerable<Package> packageTypes)
        {
            var result = GetCombinationsWithRepetitionAllowEmpty(packageTypes, maxNumPackages).Select(p => new Packages() { PackageArray = p.ToArray() });

            return result.OrderBy(r => r.TotalPrice);
        }

        /// <summary>
        /// Like GetCombinationsWithRepetition, except it allows all values between r=1 and the actual r value
        /// 
        /// Number of elements return = Σ{i=1, r](i+n-1)!/(i!(n-1)!)
        /// where n is the length of <paramref name="valueTypes"/>
        /// 
        /// e.g. for the list 'A', 'B', 'C' with r = 3, you'd get
        /// 
        /// 'A',
        /// 'B',
        /// 'C',
        /// 'A', 'A'
        /// 'A', 'B'
        /// 'A', 'C'
        /// 'B', 'B'
        /// 'B', 'C'
        /// 'C', 'C'
        /// 'A', 'A', 'A'
        /// 'A', 'A', 'B'
        /// 'A', 'A', 'C'
        /// 'A', 'B', 'B'
        /// 'A', 'B', 'C'
        /// 'A', 'C', 'C'
        /// 'B', 'B', 'B'
        /// 'B', 'B', 'C'
        /// 'B', 'C', 'C'
        /// 'C', 'C', 'C'
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="valueTypes"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public IEnumerable<IEnumerable<T>> GetCombinationsWithRepetitionAllowEmpty<T>(IEnumerable<T> valueTypes, int r)
        {
            for (int i = 1; i <= r; i++)
            {
                foreach (var result in GetCombinationsWithRepetition(valueTypes, i))
                {
                    yield return result;
                }
            }
        }

        /// <summary>
        /// Get combinations of an IEnumerable with repetition.
        /// 
        /// Number of elements returned = (r+n-1)!/(r!(n-1)!)
        /// 
        /// e.g. for the list 'A', 'B', 'C' with r = 3 you'd get
        /// 
        /// 'A', 'A', 'A'
        /// 'A', 'A', 'B'
        /// 'A', 'A', 'C'
        /// 'A', 'B', 'B'
        /// 'A', 'B', 'C'
        /// 'A', 'C', 'C'
        /// 'B', 'B', 'B'
        /// 'B', 'B', 'C'
        /// 'B', 'C', 'C'
        /// 'C', 'C', 'C'
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="valueTypes"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public IEnumerable<IEnumerable<T>> GetCombinationsWithRepetition<T>(IEnumerable<T> valueTypes, int r)
        {
            if (r == 1)
            {
                foreach (var valueType in valueTypes)
                {
                    yield return [valueType];
                }
            }
            else
            {
                IEnumerable<T> filteredValueTypes = valueTypes;

                foreach (T valueType in valueTypes)
                {
                    foreach (var list in GetCombinationsWithRepetition(filteredValueTypes, r-1))
                    {
                        yield return new[] { valueType }.Concat(list);
                    }

                    filteredValueTypes = filteredValueTypes.Skip(1);
                }
            }
        }
    }
}
