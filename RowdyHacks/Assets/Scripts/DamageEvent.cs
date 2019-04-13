using System;

public struct DamageEvent {
	public int amount;
	public DistributionType distribution;

	public DamageEvent(int amount, DistributionType dt=DistributionType.ActiveOnly) {
		this.amount = amount;
		this.distribution = dt;
	}
}

public enum DistributionType {
	ActiveOnly,
	AllEvenly
}