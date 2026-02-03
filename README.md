# HW4
## Devlog
### Control
The control coding of the game is implemented in the Player class, where I set up three "mails" (delegates): Point, onGameOver, and jumping. These are defined using the following code:

public delegate void Getpoint();
public event Getpoint Point;

public delegate void GameOver();
public event GameOver onGameOver;

public delegate void Jumps();
public event Jumps jumping;

These three "mails" are "delivered" (event) in specific method or if statement. When Input.GetKeyDown(KeyCode.Space) is detected (the player jumps), I trigger the event: jumping?.Invoke();. When the player’s GameObject collides with a GameObject tagged "point", I send the event: Point?.Invoke();. When the player’s GameObject collides with a GameObject tagged "pip", I trigger event: onGameOver?.Invoke();.

### View
All view Coding is contained in the GameController class. When the corresponding "mail" is "delivered" , the "mailbox" (event Handle) executes the associated method. I created three event handlers in GameController: GameOverHandle, AddPoint, and JumpHandle, each subscribed to a respective event:

play.onGameOver += GameOverHandle;

play.Point += AddPoint;

play.jumping += JumpHandle;

To get the Player class directly in GameController, I use the code player play = Locator.Instance.playerss; relate with the Locator script. Additionally, the following code in the Locator class ensures a single instance (Singleton pattern):

if (Instance != null && Instance != this)

{

    Destroy(this);

    return;

}

Instance = this;

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites