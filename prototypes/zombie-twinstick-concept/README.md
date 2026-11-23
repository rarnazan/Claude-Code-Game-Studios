<!-- PROTOTYPE - NOT FOR PRODUCTION
     Question: Does dual touch-stick control feel satisfying on a phone (Android)?
     Date: 2026-11-23 -->

# zombie-twinstick (prototype)

Throwaway Unreal Engine 5.8 scaffold for a top-down zombie shooter. Only the minimum
needed to test dual-stick touch control.

## Hypothesis

If the player moves and aims with dual touch sticks (left: move, right: aim and fire),
control will feel satisfying. Validated if the player survives 2 waves within 3 minutes.
Riskiest assumption: touch dual-stick precision and responsiveness on a phone.

## Status

In progress. Scaffold only. The C++ module has not been compiled here. It needs to be
opened and built on the dev machine (Windows, UE 5.8 at `C:/Program Files/Epic Games/UE_5.8`).

## Findings

None yet. Fill in after the playtest.

## Run it

1. Open `ZombieTwinStick.uproject` in UE 5.8 and accept the rebuild prompt.
2. Set the Android device or preview to test touch input.
3. Report what you see. Errors are pasted back and fixed in the next iteration.

## Scope (from the plan)

- One arena, one weapon, slow zombie waves, player and zombie health bars, score
- Left thumb moves, right thumb aims and fires

Cut: menus, sound, save, multiple weapons, bosses, monetization, error handling.
