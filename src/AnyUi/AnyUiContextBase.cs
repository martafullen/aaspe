﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnyUi
{
    /// <summary>
    /// Holds the overall context; for the specific implementations, will contain much more funtionality.
    /// Provides also hooks for the dialogues.
    /// </summary>
    public class AnyUiContextBase
    {
        /// <summary>
        /// This function is called from multiple places inside this class to emit an labda action
        /// to the superior logic of the application
        /// </summary>
        /// <param name="action"></param>
        public virtual void EmitOutsideAction(AnyUiLambdaActionBase action)
        {

        }

        /// <summary>
        /// Tries to revert changes in some controls.
        /// </summary>
        /// <returns>True, if changes were applied</returns>
        public virtual bool CallUndoChanges(AnyUiUIElement root)
        {
            return false;
        }

        /// <summary>
        /// If supported by implementation technology, will set Clipboard (copy/ paste buffer)
        /// of the main application computer.
        /// </summary>
        /// <param name="txt"></param>
        public virtual void ClipboardSetText(string txt)
        {
        }

        /// <summary>
        /// Graphically highlights/ marks an element to be "selected", e.g for seacg/ replace
        /// operations.
        /// </summary>
        /// <param name="el">AnyUiElement</param>
        /// <param name="highlighted">True for highlighted, set for clear state</param>
        public virtual void HighlightElement(AnyUiFrameworkElement el, bool highlighted)
        {
        }

        /// <summary>
        /// Show MessageBoxFlyout with contents
        /// </summary>
        /// <param name="message">Message on the main screen</param>
        /// <param name="caption">Caption string (title)</param>
        /// <param name="buttons">Buttons according to WPF standard messagebox</param>
        /// <param name="image">Image according to WPF standard messagebox</param>
        /// <returns></returns>
        public virtual AnyUiMessageBoxResult MessageBoxFlyoutShow(
            string message, string caption, AnyUiMessageBoxButton buttons, AnyUiMessageBoxImage image)
        {
            return AnyUiMessageBoxResult.Cancel;
        }

        /// <summary>
        /// Shows specified dialogue hardware-independent. The technology implementation will show the
        /// dialogue based on the type of provided <c>dialogueData</c>. 
        /// Modal dialogue: this function will block, until user ends dialogue.
        /// </summary>
        /// <param name="dialogueData"></param>
        /// <returns>If the dialogue was end with "OK" or similar success.</returns>
        public virtual bool StartFlyoverModal(AnyUiDialogueDataBase dialogueData)
        {
            return false;
        }

        /// <summary>
        /// Shows specified dialogue hardware-independent. The technology implementation will show the
        /// dialogue based on the type of provided <c>dialogueData</c>. 
        /// Non-modal: This function wil return immideately after initially displaying the dialogue.
        /// </summary>
        /// <param name="dialogueData"></param>
        /// <returns>If the dialogue was end with "OK" or similar success.</returns>
        public virtual void StartFlyover(AnyUiDialogueDataBase dialogueData)
        {
        }

        /// <summary>
        /// Closes started flyover dialogue-
        /// </summary>
        public virtual void CloseFlyover()
        {
        }

        //
        // some special functions
        // TODO (MIHO, 2020-12-24): check if to move/ refactor these functions
        //

        public virtual void PrintSingleAssetCodeSheet(
            string assetId, string description, string title = "Single asset code sheet")
        { }

        /// <summary>
        /// Set by the implementation technology (derived class of this), if Shift is pressed
        /// </summary>
        public bool ActualShiftState = false;

        /// <summary>
        /// Set by the implementation technology (derived class of this), if Cntrl is pressed
        /// </summary>
        public bool ActualControlState = false;

        /// <summary>
        /// Set by the implementation technology (derived class of this), if Akt is pressed
        /// </summary>
        public bool ActualAltState = false;
    }
}
