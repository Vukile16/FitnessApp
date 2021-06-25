﻿using FitnessApp.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessApp.ViewModels
{
    public class FeaturedViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Grouping<string, WorkoutGroup>> Workouts { get; set; }

        public FeaturedViewModel()
        {
            Workouts = new ObservableRangeCollection<Grouping<string, WorkoutGroup>>();

            var workouts = new List<Workout>();
            workouts.Add(new Workout
            {
                Name = "10 min Savasana",
                Category = "SPANISH",
                Date = "Wednesday 06/09/2021 @ 7:00 AM",
                Image = "collection1.png",
                Bookmarked = false
            });
            
            workouts.Add(new Workout
            {
                Name = "15 min Chair Yoga",
                Category = "YOGA",
                Date = "Wednesday 06/09/2021 @ 7:00 AM",
                Image = "collection2.png",
                Bookmarked = true
            });
            
            workouts.Add(new Workout
            {
                Name = "30 min Classsical Slow Flow",
                Category = "YOGA",
                Date = "Wednesday 06/09/2021 @ 3:00 PM",
                Image = "collection2.png",
                Bookmarked = false
            });

            var yogaPicks = new Grouping<string, WorkoutGroup>("Yoga Picks", new[] { new WorkoutGroup(workouts.OrderBy(x => Guid.NewGuid()).ToList()) });
            var meditataionPicks = new Grouping<string, WorkoutGroup>("Meditataion Picks", new[] { new WorkoutGroup(workouts.OrderBy(x => Guid.NewGuid()).ToList()) });
            var cardioPicks = new Grouping<string, WorkoutGroup>("Cardio Picks", new[] { new WorkoutGroup(workouts.OrderBy(x => Guid.NewGuid()).ToList()) });
            var pelotonPicks = new Grouping<string, WorkoutGroup>("Peloton Picks", new[] { new WorkoutGroup(workouts.OrderBy(x => Guid.NewGuid()).ToList()) });

            Workouts.AddRange(new[] { yogaPicks, meditataionPicks, cardioPicks, pelotonPicks });

        }
    }
}
