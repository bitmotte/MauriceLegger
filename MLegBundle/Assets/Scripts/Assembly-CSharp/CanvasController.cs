[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class CanvasController : MonoSingleton<CanvasController>
{
	public Crosshair crosshair { get; private set; }

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}
}
