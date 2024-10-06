# Decorator Pattern With Unity

## Watch
![Game_play](https://github.com/user-attachments/assets/6ee94aa2-7971-4d66-b28e-cd7e6dc167be)

## UML Diagram
![Decorator_UML](https://github.com/user-attachments/assets/daf47dda-ca79-4840-b7d2-0a4d7267636e)

## What is the Decorator Pattern?
The Decorator Pattern is a structural design pattern that allows behavior to be added to individual objects, dynamically and independently, without affecting the behavior of other objects from the same class. It is used to extend the functionalities of an object in a flexible and reusable way. The decorator pattern wraps the original object and provides additional functionalities while keeping the original object's structure intact.

In this project, we show how various weapon types can be dynamically enhanced with different effects such as freezing, poisoning, etc. using the decorator pattern.

## Benefits 
- **Flexibility:** The decorator pattern allows you to add functionalities to an object dynamically, without modifying the underlying class. You can apply multiple decorators to a single object, combining different behaviors.
- **Code Reusability:** Instead of creating multiple subclasses for each variation of an object, the decorator pattern lets you reuse the same base class and extend it with different behaviors.
- **Scalability:** As new features or behaviors need to be added, you can create new decorators and apply them without needing to alter existing code. This reduces the risk of introducing bugs into the system.
- **Separation of Concerns:** Each decorator class is responsible for a specific behavior, making the code easier to understand and maintain.

## Project Structure

        ├── Scripts/
        │   ├── Cards/          
        │   │   └── Card.cs        
        │   ├── Core/          
        │   │   └── GameBootstrapper.cs          
        │   ├── Data/          
        │   │   └── WeaponData.cs        
        │   ├── Decorator/          
        │   │   ├── ExplosiveAmmoDecorator.cs 
        │   │   ├── FreezeDecorator.cs            
        │   │   ├── PoisonDecorator.cs 
        │   │   ├── RapidFireDecorator.cs  
        │   │   ├── RegenDecorator.cs  
        │   │   ├── SpellCasterDecorator.cs     
        │   │   └── ShieldDecorator.cs   
        │   ├── UI/          
        │   │   ├── DragHandler.cs 
        │   │   └── DropHandler.cs  
        │   ├── MachineGun.cs    
        │   ├── Weapon.cs    
        │   └── WeaponManager.cs    


## Requirements
- Unity 2020.3 or later

## How to Use

1. Clone the repository:
   ```bash
   git clone https://github.com/your_username/your-repository.git

2. Open the project in Unity:
   Navigate to the project folder and open the Unity project.

3. Play the demo:
   Press the "Play" button in Unity to start the scene.
   Drag and drop different cards onto the weapon to add features like freezing, poisoning, or explosive ammo.
   Fire the weapon to see the applied features in action.
