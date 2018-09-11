--Tab -> Intellisense
--Fn+F5 -> Execute Query
--Ctrl+R -> Get rid of results

--x--x--x-- 1. BASIC --x--x--x--

--1
SELECT
	FilmName Title,
	FilmReleaseDate AS 'Released On',
	FilmRunTimeMinutes [Mins]
FROM
	tblFilm

--x--x--x-- 2. ORDER BY --x--x--x--

--1
SELECT
	FilmName Title,
	FilmReleaseDate AS 'Released On',
	FilmRunTimeMinutes [Mins]
FROM
	tblFilm
ORDER BY
	FilmName ASC
--2
SELECT
	FilmName Title,
	FilmReleaseDate AS 'Released On',
	FilmRunTimeMinutes [Duration]
FROM
	tblFilm
ORDER BY
	 Duration DESC,
	 Title ASC
--3
SELECT TOP 5 WITH TIES
	FilmName Title,
	FilmReleaseDate AS 'Released On',
	FilmRunTimeMinutes [Duration],
	FilmOscarWins
FROM
	tblFilm
ORDER BY
	 FilmOscarWins DESC

--x--x--x-- 3. WHERE --x--x--x--

--1
SELECT
	FilmName AS Title,
	FilmReleaseDate AS Release,
	FilmRunTimeMinutes As Duration
FROM
	tblFilm
WHERE
	FilmRunTimeMinutes >= 120
ORDER BY
	Duration

--2
SELECT
	FilmName AS Title,
	FilmReleaseDate AS Release,
	FilmRunTimeMinutes As Duration
FROM
	tblFilm
WHERE
	FilmRunTimeMinutes IN (90,120,180)
ORDER BY
	Duration

--3
SELECT
	FilmName AS Title,
	FilmReleaseDate AS Release,
	FilmRunTimeMinutes As Duration
FROM
	tblFilm
WHERE
	FilmName = 'die hard'
ORDER BY
	Duration

--4
SELECT
	FilmName AS Title,
	FilmReleaseDate AS Release,
	FilmRunTimeMinutes As Duration
FROM
	tblFilm
WHERE
	FilmName LIKE '%die hard%'
ORDER BY
	Duration

--5
SELECT
	FilmName AS Title,
	FilmReleaseDate AS Release,
	FilmRunTimeMinutes As Duration
FROM
	tblFilm
WHERE
	FilmName LIKE 'die hard__'
ORDER BY
	Duration

--6
SELECT
	FilmName AS Title,
	FilmReleaseDate AS Release,
	FilmRunTimeMinutes As Duration
FROM
	tblFilm
WHERE
	FilmName NOT LIKE 'die hard__'
ORDER BY
	Duration

--7
SELECT
	FilmName AS Title,
	FilmReleaseDate AS Release,
	FilmRunTimeMinutes As Duration
FROM
	tblFilm
WHERE
	FilmReleaseDate = '2002-8-2'
ORDER BY
	Duration

--8
SELECT
	FilmName AS Title,
	FilmReleaseDate AS Release,
	FilmRunTimeMinutes As Duration
FROM
	tblFilm
WHERE
	FilmReleaseDate BETWEEN '8/2/2002' AND '8/2/2010'
ORDER BY
	Release

--9
SELECT
	FilmName AS Title,
	FilmReleaseDate AS Release,
	FilmRunTimeMinutes As Duration
FROM
	tblFilm
WHERE
	MONTH(FilmReleaseDate) = 2
ORDER BY
	Release

--10
SELECT
	FilmName AS Title,
	FilmReleaseDate AS Release,
	FilmRunTimeMinutes As Duration
FROM
	tblFilm
WHERE
	FilmRunTimeMinutes < 120 AND
	(FilmName LIKE 'x%' OR
	FilmName LIKE 'y%')
ORDER BY
	Title

--x--x--x-- 4. CALCULATED COLUMNS IN QUERIES --x--x--x--

--1
SELECT
	FilmName AS Title,
	(FilmBoxOfficeDollars-FilmBudgetDollars) AS Profit
FROM
	tblFilm
WHERE
	(FilmBoxOfficeDollars-FilmBudgetDollars) < 0
ORDER BY
	Profit DESC

--2
SELECT
	FilmName AS Title,
	FilmRunTimeMinutes/60.0 AS Duration,
	FilmBoxOfficeDollars*0.2 AS Tax,
	FilmBudgetDollars+(FilmBoxOfficeDollars*0.2) AS Budget
FROM
	tblFilm
ORDER BY
	FilmRunTimeMinutes DESC

--3
SELECT
	FilmName AS Title,
	FilmRunTimeMinutes/60 AS "HOURS",
	FilmRunTimeMinutes%60 AS "MINUTES"
FROM
	tblFilm
ORDER BY
	FilmRunTimeMinutes DESC

--x--x--x-- 5. CASE EXPRESSIONS --x--x--x--

--1
SELECT
	FilmName AS Title,
	CASE
	WHEN FilmRunTimeMinutes <= 90 THEN 'Short'
	WHEN FilmRunTimeMinutes <= 120 THEN 'Medium'
	WHEN FilmRunTimeMinutes <= 150 THEN 'Big'
	ELSE 'Exciting'
	END AS Duration
FROM
	tblFilm

--2
SELECT
	FilmName AS Title,
	CASE
	WHEN FilmName LIKE '%Ocean%' THEN 'Not Good'
	ELSE 'Fine'
	END AS Watch
FROM
	tblFilm
ORDER BY
	Title

--x--x--x-- 6. JOINS --x--x--x--

--1
SELECT
	f.FilmName AS Title,
	d.DirectorName AS Director,
	c.CountryName AS Country
FROM
	tblFilm AS f
	INNER JOIN tblDirector AS d
		ON f.FilmDirectorID = d.DirectorID
	INNER JOIN tblCountry AS c
		ON f.FilmCountryID = c.CountryID

--2
SELECT
	f.FilmName AS Title,
	d.DirectorName AS Director
FROM
	tblFilm AS f
	RIGHT OUTER JOIN tblDirector AS d
		ON f.FilmDirectorID = d.DirectorID

--3
SELECT
	f.FilmName AS Title,
	d.DirectorName AS Director
FROM
	tblFilm AS f
	RIGHT OUTER JOIN tblDirector AS d
		ON f.FilmDirectorID = d.DirectorID
WHERE
	f.FilmName IS NULL

--4
SELECT
	f.FilmName AS Title,
	d.DirectorName AS Director
FROM
	tblFilm AS f
	FULL OUTER JOIN tblDirector AS d
		ON f.FilmDirectorID = d.DirectorID

--x--x--x-- 7. FUNCTIONS --x--x--x--

--1
SELECT
	FilmName AS Title,
	UPPER(FilmName) AS TITLE,
	DATENAME("M",FilmReleaseDate) AS 'Month',
	DATEDIFF("D",FilmReleaseDate,GETDATE()) AS 'DAYS OLD'
FROM
	tblFilm