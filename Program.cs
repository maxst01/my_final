DateTime start = DateTime.ParseExact("22/10/2018 15:00:00", "dd/MM/yyyy HH:mm:ss");
DateTime end = DateTime.ParseExact("23/10/2018 17:35:00", "dd/MM/yyyy HH:mm:ss", ConcurrentExclusiveSchedulerPair.InvariantCulture);
TimeSpan result = end - start;