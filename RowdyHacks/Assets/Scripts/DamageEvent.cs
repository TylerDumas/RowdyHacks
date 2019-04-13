using System;

/*
 * A struct representing damage to be delt to the player's
 * party
 *
 * amount : int
 *   the magnitude of the damage to deal
 * distribution : DistributionType
 *   the distribution stratagy
 */
public struct DamageEvent {
	public int amount;
	public DistributionType distribution;

	public DamageEvent(int amount, DistributionType dt=DistributionType.ActiveOnly) {
		this.amount = amount;
		this.distribution = dt;
	}
}

/*
 * An enum for different distribution stratagies
 */
public enum DistributionType {
	ActiveOnly,
	AllEvenly
}