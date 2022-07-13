        public class Building
        {
            private int _buildingNumber;

            private int _buildingHeight;

            private int _buildingStoreys;

            private int _numberOfApartments;

            private int _numberOfEntrance;

            private static int _buildNumber = 0;

            private static int CreateBuildNumber()
            {

                return _buildNumber++;
            }

            public int BuildingNumber
            {
                get => _buildingNumber;
                set => _buildingNumber = value;
            }

            public int BuildingHeight
            {
                get => _buildingHeight;
                set => _buildingHeight = value;
            }

            public int BuildingStoreys
            {
                get => _buildingStoreys;
                set => _buildingStoreys = value;
            }

            public int NumberOfApartments
            {
                get => _numberOfApartments;
                set => _numberOfApartments = value;
            }

            public int NumberOfEntrance
            {
                get => _numberOfEntrance;
                set => _numberOfEntrance = value;
            }
            /// <summary>
            /// Метод для вычесления высоты этажа
            /// </summary>
            /// <param name="buldingHeight">высота здания</param>
            /// <param name="buildingStoreys">количество этажей</param>
            /// <returns></returns>
            public static int FloorHeight(int buldingHeight, int buildingStoreys)
            {
                return buldingHeight / buildingStoreys;
            }
            /// <summary>
            /// Метод для вычесления количества квартир в подъезде
            /// </summary>
            /// <param name="numberOfApartments">Количество квартир в доме</param>
            /// <param name="numberOfEntrance">Количество подъездов</param>
            /// <returns></returns>
            public static int HowMuchAps(int numberOfApartments, int numberOfEntrance)
            {
                return numberOfApartments / numberOfEntrance;
            }
            /// <summary>
            /// Метод для вычесления количства квартир на этаже
            /// </summary>
            /// <param name="numberOfFlats"></param>
            /// <param name="floors"></param>
            /// <returns></returns>
            public static int ApsOnFloor(int numberOfFlats, int floors)
            {
                return numberOfFlats / floors;
            }

            public Building(int buildingNumber, int buildingHeight, int buildingStoreys, int numberOfApartments, int numberOfEntrance)
            {
                _buildingNumber = buildingNumber;
                _buildingHeight = buildingHeight;
                _buildingStoreys = buildingStoreys;
                _numberOfApartments = numberOfApartments;
                _numberOfEntrance = numberOfEntrance;
            }
            public Building(int buildingHeight, int buildingStoreys, int numberOfApartments, int numberOfEntrance)
            {
                _buildingNumber = CreateBuildNumber();
                _buildingHeight = buildingHeight;
                _buildingStoreys = buildingStoreys;
                _numberOfApartments = numberOfApartments;
                _numberOfEntrance = numberOfEntrance;
            }

            public Building()
            {
                _buildingNumber = CreateBuildNumber();
                _buildingHeight = 12;
                _buildingStoreys = 4;
                _numberOfApartments = 16;
                _numberOfEntrance = 1;
            }
        }