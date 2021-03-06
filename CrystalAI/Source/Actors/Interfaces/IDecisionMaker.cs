// GPL v3 License
// 
// Copyright (c) 2016-2017 Bismur Studios Ltd.
// Copyright (c) 2016-2017 Ioannis Giagkiozis
// 
// IDecisionMaker.cs is part of Crystal AI.
//  
// Crystal AI is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//  
// Crystal AI is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Crystal AI.  If not, see <http://www.gnu.org/licenses/>.
namespace Crystal {

  /// <summary>
  ///   Interface for the decision maker. The only responsibility of the decision maker is
  ///   to manage its associated AI.
  /// </summary>
  public interface IDecisionMaker {
    /// <summary>
    ///   The state of the decision maker.
    /// </summary>
    DecisionMakerState State { get; }

    /// <summary>
    ///   Starts the associated AI and sets the decision maker state to
    ///  <see cref="F:Crystal.DecisionMakerState.Running"/>.
    /// </summary>
    void Start();

    /// <summary>
    ///   Stops the associated AI and sets the decision maker state to
    ///  <see cref="F:Crystal.DecisionMakerState.Stopped"/>.
    /// </summary>
    void Stop();

    /// <summary>
    ///   Pauses the associated AI and the decision maker state to 
    /// <see cref="F:Crystal.DecisionMakerState.Paused"/>.
    /// </summary>
    void Pause();

    /// <summary>
    ///   Resumes execution of the associated AI and sets the decision maker state to 
    /// <see cref="F:Crystal.DecisionMakerState.Running"/>.
    /// </summary>
    void Resume();

    /// <summary>
    ///   Thinks about what to do next. This is the decision making cycle of the AI.
    /// </summary>
    void Think();

    /// <summary>
    ///   Updates the action selected by Think() - that is if it needs updating, otherwise this will
    ///   simply return.
    /// </summary>
    void Update();
  }

}