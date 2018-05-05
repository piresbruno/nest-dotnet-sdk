﻿#region License

//   Copyright 2018 Elton FAN (eltonfan@live.cn, http://elton.io)
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

#endregion

using Elton.Nest.Models;
using Elton.Nest.Rest;
using Elton.Nest.Rest.Parsers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Nest.Setters
{
    public class ThermostatSetter
    {
        private static string getPath(string thermostatId)
        {
            return new Utils.PathBuilder()
                .Append(Constants.KEY_DEVICES)
                .Append(Constants.KEY_THERMOSTATS)
                .Append(thermostatId)
                .Build();
        }

        readonly RestClient restClient;
        public ThermostatSetter(RestClient restClient)
        {
            this.restClient = restClient;
        }

        /// <summary>
        /// Sets the desired temperature, in full degrees Fahrenheit (1&deg;F). Used when hvac_mode =
        /// "heat" or "cool".
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The desired temperature in full degrees Fahrenheit.
        /// @param callback     A {@link Callback} to receive whether the change was successful.
        /// </summary>
        public void setTargetTemperatureF(string thermostatId, long temperature, Callback callback)
        {
            restClient.writeLong(getPath(thermostatId), Thermostat.KEY_TARGET_TEMP_F, temperature, callback);
        }

        /// <summary>
        /// Sets the desired temperature, in full degrees Fahrenheit (1&deg;F). Used when hvac_mode =
        /// "heat" or "cool".
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The desired temperature in full degrees Fahrenheit.
        /// </summary>
        public void setTargetTemperatureF(string thermostatId, long temperature)
        {
            setTargetTemperatureF(thermostatId, temperature, null);
        }

        /// <summary>
        /// Sets the desired temperature, in half degrees Celsius (0.5&deg;C). Used when hvac_mode =
        /// "heat" or "cool".
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The desired temperature, in half degrees Celsius (0.5&deg;C).
        /// @param callback     A {@link Callback} to receive whether the change was successful.
        /// </summary>
        public void setTargetTemperatureC(string thermostatId, double temperature, Callback callback)
        {
            restClient.writeDouble(getPath(thermostatId), Thermostat.KEY_TARGET_TEMP_C, temperature, callback);
        }

        /// <summary>
        /// Sets the desired temperature, in half degrees Celsius (0.5&deg;C). Used when hvac_mode =
        /// "heat" or "cool".
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The desired temperature, in half degrees Celsius (0.5&deg;C).
        /// </summary>
        public void setTargetTemperatureC(string thermostatId, double temperature)
        {
            setTargetTemperatureC(thermostatId, temperature, null);
        }

        /// <summary>
        /// Sets the minimum target temperature, displayed in whole degrees Fahrenheit (1&deg;F). Used
        /// when hvac_mode = "heat-cool" (Heat / Cool mode).
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The minimum desired temperature, displayed in whole degrees Fahrenheit.
        /// @param callback     A {@link Callback} to receive whether the change was successful.
        /// </summary>
        public void setTargetTemperatureLowF(string thermostatId, long temperature, Callback callback)
        {
            restClient.writeLong(getPath(thermostatId), Thermostat.KEY_TARGET_TEMP_LOW_F, temperature, callback);
        }

        /// <summary>
        /// Sets the minimum target temperature, displayed in whole degrees Fahrenheit (1&deg;F). Used
        /// when hvac_mode = "heat-cool" (Heat / Cool mode).
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The minimum desired temperature, displayed in whole degrees Fahrenheit.
        /// </summary>
        public void setTargetTemperatureLowF(string thermostatId, long temperature)
        {
            setTargetTemperatureLowF(thermostatId, temperature, null);
        }

        /// <summary>
        /// Sets the minimum target temperature, displayed in half degrees Celsius (0.5&deg;C). Used when
        /// hvac_mode = "heat-cool" (Heat / Cool mode).
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The minimum target temperature, displayed in half degrees Celsius.
        /// @param callback     A {@link Callback} to receive whether the change was successful.
        /// </summary>
        public void setTargetTemperatureLowC(string thermostatId, double temperature, Callback callback)
        {
            restClient.writeDouble(getPath(thermostatId), Thermostat.KEY_TARGET_TEMP_C, temperature, callback);
        }

        /// <summary>
        /// Sets the minimum target temperature, displayed in half degrees Celsius (0.5&deg;C). Used when
        /// hvac_mode = "heat-cool" (Heat / Cool mode).
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The minimum target temperature, displayed in half degrees Celsius.
        /// </summary>
        public void setTargetTemperatureLowC(string thermostatId, double temperature)
        {
            setTargetTemperatureLowC(thermostatId, temperature, null);
        }

        /// <summary>
        /// Sets the maximum target temperature, displayed in whole degrees Fahrenheit (1&deg;F). Used
        /// when hvac_mode = "heat-cool" (Heat / Cool mode).
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The maximum desired temperature, displayed in whole degrees Fahrenheit.
        /// @param callback     A {@link Callback} to receive whether the change was successful.
        /// </summary>
        public void setTargetTemperatureHighF(string thermostatId, long temperature, Callback callback)
        {
            restClient.writeLong(getPath(thermostatId), Thermostat.KEY_TARGET_TEMP_HIGH_F, temperature, callback);
        }

        /// <summary>
        /// Sets the maximum target temperature, displayed in whole degrees Fahrenheit (1&deg;F). Used
        /// when hvac_mode = "heat-cool" (Heat / Cool mode).
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The maximum desired temperature, displayed in whole degrees Fahrenheit.
        /// </summary>
        public void setTargetTemperatureHighF(string thermostatId, long temperature)
        {
            setTargetTemperatureHighF(thermostatId, temperature, null);
        }

        /// <summary>
        /// Sets the maximum target temperature, displayed in half degrees Celsius (0.5&deg;C). Used when
        /// hvac_mode = "heat-cool" (Heat / Cool mode).
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The maximum target temperature, displayed in half degrees Celsius.
        /// @param callback     A {@link Callback} to receive whether the change was successful.
        /// </summary>
        public void setTargetTemperatureHighC(string thermostatId, double temperature, Callback callback)
        {
            restClient.writeDouble(getPath(thermostatId), Thermostat.KEY_TARGET_TEMP_HIGH_C, temperature, callback);
        }

        /// <summary>
        /// Sets the maximum target temperature, displayed in half degrees Celsius (0.5&deg;C). Used when
        /// hvac_mode = "heat-cool" (Heat / Cool mode).
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param temperature  The maximum target temperature, displayed in half degrees Celsius.
        /// </summary>
        public void setTargetTemperatureHighC(string thermostatId, double temperature)
        {
            setTargetTemperatureHighC(thermostatId, temperature, null);
        }

        /// <summary>
        /// Sets the HVAC system heating/cooling modes. For systems with both heating and cooling
        /// capability, set this value to "heat-cool" (Heat / Cool mode) to get the best experience.
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param mode         The heating/cooling mode. Values can be "heat", "cool", "heat-cool", or
        ///                     "off".
        /// @param callback     A {@link Callback} to receive whether the change was successful.
        /// </summary>
        public void setHVACMode(string thermostatId, string mode, Callback callback)
        {
            restClient.writeString(getPath(thermostatId), Thermostat.KEY_HVAC_MODE, mode, callback);
        }

        /// <summary>
        /// Sets the HVAC system heating/cooling modes. For systems with both heating and cooling
        /// capability, set this value to "heat-cool" (Heat / Cool mode) to get the best experience.
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param mode         The heating/cooling mode. Values can be "heat", "cool", "heat-cool", or
        ///                     "off".
        /// </summary>
        public void setHVACMode(string thermostatId, string mode)
        {
            setHVACMode(thermostatId, mode, null);
        }

        /// <summary>
        /// Sets whether the fan timer is engaged; used with fanTimerTimeout to turn on the fan for a
        /// (user-specified) preset duration.
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param isActive     true if the fan timer is to be engaged, false if the fan timer should be
        ///                     disengaged.
        /// @param callback     A {@link Callback} to receive whether the change was successful.
        /// </summary>
        public void setFanTimerActive(string thermostatId, bool isActive, Callback callback)
        {
            restClient.writeBoolean(getPath(thermostatId), Thermostat.KEY_FAN_TIMER_ACTIVE, isActive, callback);
        }

        /// <summary>
        /// Sets whether the fan timer is engaged; used with fanTimerTimeout to turn on the fan for a
        /// (user-specified) preset duration.
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param isActive     true if the fan timer is to be engaged, false if the fan timer should be
        ///                     disengaged.
        /// </summary>
        public void setFanTimerActive(string thermostatId, bool isActive)
        {
            setFanTimerActive(thermostatId, isActive, null);
        }

        /// <summary>
        /// Sets the thermostat scale to Fahrenheit or Celsius; used with temperature display.
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param tempScale    A string for temperature scale. "F" for Fahrenheit, "C" for Celsius.
        /// </summary>
        public void setTemperatureScale(string thermostatId, string tempScale, Callback callback)
        {
            restClient.writeString(getPath(thermostatId), Thermostat.KEY_TEMP_SCALE, tempScale, callback);
        }

        /// <summary>
        /// Sets the thermostat label.
        ///
        /// @param thermostatId The unique identifier for the {@link Thermostat}.
        /// @param label        A string for the custom label.
        /// </summary>
        public void setLabel(string thermostatId, string label, Callback callback)
        {
            restClient.writeString(getPath(thermostatId), Thermostat.KEY_LABEL, label, callback);
        }
    }
}