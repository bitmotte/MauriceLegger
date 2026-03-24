using ScriptableObjects;
using UnityEngine;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class DefaultReferenceManager : MonoSingleton<DefaultReferenceManager>
{
	public GameObject wetParticle;

	public GameObject sandDrip;

	public GameObject blessingGlow;

	public GameObject sandificationEffect;

	public GameObject enrageEffect;

	public GameObject ineffectiveSound;

	public GameObject continuousSplash;

	public GameObject splash;

	public GameObject smallSplash;

	public GameObject bubbles;

	public GameObject projectile;

	public GameObject projectileExplosive;

	public GameObject parryableFlash;

	public GameObject unparryableFlash;

	public GameObject explosion;

	public GameObject superExplosion;

	public Material puppetMaterial;

	public GameObject puppetSpawn;

	public Material blankMaterial;

	public GameObject madnessEffect;

	public LineRenderer electricLine;

	public GameObject zapImpactParticle;

	public FootstepSet footstepSet;

	public GameObject radianceEffect;

	public Shader masterShader;

	public GameObject terminalVelocityEffect;

	public GameObject terminalVelocityExtinguish;

	[Header("Enemies")]
	public GameObject bigJohnator;

	public GameObject cancerousRodent;

	public GameObject centaur;

	public GameObject cerberus;

	public GameObject deathCatcher;

	public GameObject drone;

	public GameObject ferryman;

	public GameObject filth;

	public GameObject fleshPanopticon;

	public GameObject fleshPrison;

	public GameObject gabriel;

	public GameObject gabrielSecond;

	public GameObject gutterman;

	public GameObject guttertank;

	public GameObject hideousMass;

	public GameObject idol;

	public GameObject leviathan;

	public GameObject maliciousFace;

	public GameObject mandalore;

	public GameObject mannequin;

	public GameObject mindflayer;

	public GameObject minosCorpse;

	public GameObject minosPrime;

	public GameObject minotaur;

	public GameObject providence;

	public GameObject puppet;

	public GameObject schism;

	public GameObject sisyphus;

	public GameObject sisyphusPrime;

	public GameObject soldier;

	public GameObject stalker;

	public GameObject stray;

	public GameObject streetcleaner;

	public GameObject swordsmachine;

	public GameObject turret;

	public GameObject v2;

	public GameObject v2second;

	public GameObject veryCancerousRodent;

	public GameObject virtue;

	public GameObject wicked;

	public GameObject GetEnemyPrefab(EnemyType type)
	{
		return null;
	}
}
