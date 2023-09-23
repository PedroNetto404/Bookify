using Bookify.Domain.Abstractions;
using Bookify.Domain.Bookings.ValueObjects;

namespace Bookify.Domain.Bookings.Events;

public sealed record BookingCompletedEvent(BookingId BookingId) : IDomainEvent;