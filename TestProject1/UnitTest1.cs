using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lab2.Tests
{
    [TestFixture]
    public class CatalogTests
    {
        [Test]
        public void AddTrack_WhenTrackNotInCatalog_ShouldAddTrack()
        {
            var catalog = new Catalog();
            var track = new Track("Song1", "Author1");
            catalog.AddTrack(track);
            Assert.Contains(track, catalog.AllTracks as ICollection);
        }

        [Test]
        public void AddTrack_WhenTrackAlreadyInCatalog_ShouldThrowException()
        {
            var catalog = new Catalog();
            var track = new Track("Song1", "Author1");
            catalog.AddTrack(track);
            Assert.Throws<ArgumentException>(() => catalog.AddTrack(track));
        }

        [Test]
        public void RemoveTrack_WhenTrackInCatalog_ShouldRemoveTrack()
        {
            var catalog = new Catalog();
            var track = new Track("Song1", "Author1");
            catalog.AddTrack(track);
            catalog.RemoveTrack(track);
            Assert.IsEmpty(catalog.AllTracks);
        }

        [Test]
        public void RemoveTrack_WhenTrackNotInCatalog_ShouldThrowException()
        {
            var catalog = new Catalog();
            var track = new Track("Song1", "Author1");
            Assert.Throws<ArgumentException>(() => catalog.RemoveTrack(track));
        }

        [Test]
        public void SearchTrack_WhenTrackInCatalog_ShouldNotThrowException()
        {
            var catalog = new Catalog();
            var track = new Track("Song1", "Author1");
            catalog.AddTrack(track);

            // Act & Assert
            Assert.DoesNotThrow(() => catalog.SearchTrack(track));
        }

        [Test]
        public void SearchTrack_WhenTrackNotInCatalog_ShouldThrowException()
        {
            var catalog = new Catalog();
            var track = new Track("Song1", "Author1");

            // Act & Assert
            Assert.Throws<ArgumentException>(() => catalog.SearchTrack(track));
        }
    }
}