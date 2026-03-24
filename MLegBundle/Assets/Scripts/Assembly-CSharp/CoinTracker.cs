using System.Collections.Generic;
using System.Threading;
using ULTRAKILL.Enemy;

public class CoinTracker : MonoSingleton<CoinTracker>
{
	public readonly List<Coin> revolverCoinsList;

	private CancellationTokenSource untrackTargetsSource;

	private CancellationToken untrackTargetsToken;

	private CancellationTokenSource untrackCoinsSource;

	private CancellationToken untrackCoinsToken;

	public readonly Dictionary<ITarget, CancellationToken> targets;

	private void Start()
	{
	}

	public void Reset()
	{
	}

	private void ResetUntrackTargetsToken()
	{
	}

	private void ResetUntrackCoinsToken()
	{
	}

	public void AddCoin(Coin coin)
	{
	}

	private void RemoveCoin(Coin coin)
	{
	}

	private void SlowUpdate()
	{
	}

	public void RegisterTarget(ITarget target, CancellationToken token)
	{
	}

	private void RegisterCoinToTracker(TargetTracker tt, Coin coin)
	{
	}

	private void RegisterTargetToTracker(TargetTracker tt, ITarget target, CancellationToken token)
	{
	}

	private static CancellationToken CreateLinkedToken(CancellationToken t1, CancellationToken t2)
	{
		return default(CancellationToken);
	}
}
