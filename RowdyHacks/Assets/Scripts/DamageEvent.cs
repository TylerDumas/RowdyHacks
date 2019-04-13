using System;

public struct DamangeEvent {
	public int amount;
	public DistributionType distribution;

	public DamangeEvent(int amount, DistributionType dt=ActiveOnly) {
		this.amount = amount;
		this.distribution = dt;
	}
}

public enum DistributionType {
	ActiveOnly,
	AllEvenly
}