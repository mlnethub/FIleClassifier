﻿using System;

namespace FileClassifier.JobManager.REST.Databases.Tables
{
    public class Jobs
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public DateTime SubmissionTime { get; set; }

        public bool Completed { get; set; }
    }
}